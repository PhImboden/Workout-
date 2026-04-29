using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using FitnessTracker.Models;
using FitnessTracker.Services;

namespace FitnessTracker.Views
{
    public partial class ExerciseDialog : Window
    {
        private ObservableCollection<SetViewModel> _sets;

        public string SelectedExerciseName { get; private set; }
        public string MuscleGroup { get; private set; }
        public ObservableCollection<Set> ResultSets { get; private set; }

        public ExerciseDialog()
        {
            InitializeComponent();
            _sets = new ObservableCollection<SetViewModel>();
            SetsList.ItemsSource = _sets;

            // Load exercises and muscle groups
            var exercises = ExerciseCatalog.GetDefaultExercises();
            ExerciseCombo.ItemsSource = exercises;

            var muscles = ExerciseCatalog.GetMuscleGroups();
            MuscleCombo.ItemsSource = muscles;
            MuscleCombo.SelectedIndex = 0;

            // Add first set by default
            AddNewSet();
        }

        private void AddSet_Click(object sender, RoutedEventArgs e)
        {
            AddNewSet();
        }

        private void AddNewSet()
        {
            var newSet = new SetViewModel { SetNumber = _sets.Count + 1 };
            _sets.Add(newSet);
            UpdateVolumeInfo();
        }

        private void RemoveSet_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag is SetViewModel setVm)
            {
                _sets.Remove(setVm);
                UpdateSetNumbers();
                UpdateVolumeInfo();
            }
        }

        private void UpdateSetNumbers()
        {
            for (int i = 0; i < _sets.Count; i++)
            {
                _sets[i].SetNumber = i + 1;
            }
        }

        private void UpdateVolumeInfo()
        {
            double totalVolume = _sets.Sum(s => (s.Reps ?? 0) * (s.Weight ?? 0));
            VolumeInfo.Text = $"{totalVolume:F1} kg";
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            // Validate
            string exerciseName = null;

            // Check if exercise was selected from combo
            if (ExerciseCombo.SelectedItem is Exercise selectedEx)
            {
                exerciseName = selectedEx.Name;
                MuscleGroup = selectedEx.Muscle;
            }
            else if (!string.IsNullOrWhiteSpace(CustomExerciseText.Text))
            {
                // Use custom exercise name
                exerciseName = CustomExerciseText.Text.Trim();
                MuscleGroup = MuscleCombo.SelectedItem?.ToString() ?? "Sonstiges";
            }

            if (string.IsNullOrWhiteSpace(exerciseName))
            {
                MessageBox.Show("Bitte wähle eine Übung oder gib einen Namen ein", 
                    "Validierungsfehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (_sets.Count == 0)
            {
                MessageBox.Show("Bitte füge mindestens ein Set hinzu", 
                    "Validierungsfehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Validate all sets have values
            foreach (var set in _sets)
            {
                if (!set.Reps.HasValue || set.Reps.Value <= 0)
                {
                    MessageBox.Show("Bitte gib für alle Sets Wiederholungen ein", 
                        "Validierungsfehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                if (!set.Weight.HasValue || set.Weight.Value < 0)
                {
                    MessageBox.Show("Bitte gib für alle Sets ein Gewicht ein", 
                        "Validierungsfehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }

            SelectedExerciseName = exerciseName;
            ResultSets = new ObservableCollection<Set>(_sets.Select(s => 
                new Set(s.Reps ?? 0, s.Weight ?? 0)).ToList());

            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }

    /// <summary>
    /// ViewModel für ein Set in der UI (ermöglicht Bindung)
    /// </summary>
    public class SetViewModel
    {
        public int SetNumber { get; set; }
        public int? Reps { get; set; }
        public double? Weight { get; set; }
    }
}
