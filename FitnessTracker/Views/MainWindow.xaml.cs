using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using FitnessTracker.Models;
using FitnessTracker.Services;

namespace FitnessTracker.Views
{
    public partial class MainWindow : Window
    {
        private WorkoutService _workoutService;
        private Workout _selectedWorkout;
        private bool _isInitialized = false;

        public MainWindow()
        {
            InitializeComponent();
            _workoutService = App.WorkoutService;
            _isInitialized = true;
            LoadWorkouts();
        }

        private void LoadWorkouts()
        {
            RefreshWorkoutsList();
        }

        private void RefreshWorkoutsList()
        {
            var workouts = GetFilteredWorkouts();
            WorkoutsList.ItemsSource = workouts;
        }

        private List<Workout> GetFilteredWorkouts()
        {
            // Sicherheitsprüfung für Unit Tests
            if (RadioAll == null || RadioOpen == null || RadioCompleted == null)
                return _workoutService.GetAllWorkouts();

            List<Workout> workouts = new List<Workout>();

            if (RadioAll.IsChecked == true)
                workouts = _workoutService.GetAllWorkouts();
            else if (RadioOpen.IsChecked == true)
                workouts = _workoutService.GetOpenWorkouts();
            else if (RadioCompleted.IsChecked == true)
                workouts = _workoutService.GetCompletedWorkouts();

            // Suche anwenden (auf der gefilterten Liste)
            string searchTerm = SearchBox?.Text;
            if (!string.IsNullOrEmpty(searchTerm))
            {
                workouts = workouts.Where(w =>
                    w.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    w.Date.ToString("dd.MM.yyyy").Contains(searchTerm)
                ).ToList();
            }

            return workouts;
        }

        private void SearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (_isInitialized)
                RefreshWorkoutsList();
        }

        private void FilterRadio_Changed(object sender, RoutedEventArgs e)
        {
            if (_isInitialized)
                RefreshWorkoutsList();
        }

        private void WorkoutsList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _selectedWorkout = WorkoutsList.SelectedItem as Workout;
            DisplayWorkoutDetails();
        }

        private void DisplayWorkoutDetails()
        {
            if (_selectedWorkout == null)
            {
                WorkoutTitle.Text = "Kein Workout ausgewählt";
                WorkoutDate.Text = "-";
                WorkoutStatus.Text = "-";
                TotalVolume.Text = "-";
                ExerciseCount.Text = "-";
                ExercisesList.ItemsSource = null;
                EmptyMessage.Visibility = Visibility.Visible;
                return;
            }

            EmptyMessage.Visibility = Visibility.Collapsed;
            WorkoutTitle.Text = _selectedWorkout.Name;
            WorkoutDate.Text = _selectedWorkout.Date.ToString("dd.MM.yyyy HH:mm");
            WorkoutStatus.Text = _selectedWorkout.IsCompleted ? "✓ Erledigt" : "⊙ Offen";
            TotalVolume.Text = $"{_selectedWorkout.GetTotalVolume():F1} kg";
            ExerciseCount.Text = _selectedWorkout.Exercises.Count.ToString();

            ExercisesList.ItemsSource = _selectedWorkout.Exercises;

            // Button-Text anpassen
            CompleteButton.Content = _selectedWorkout.IsCompleted ? "↻ Zurück öffnen" : "✓ Als erledigt markieren";
        }

        private void NewWorkout_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new WorkoutDialog();
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    _workoutService.CreateWorkout(dialog.WorkoutName, dialog.WorkoutDate);
                    RefreshWorkoutsList();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void EditWorkout_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedWorkout == null)
            {
                MessageBox.Show("Bitte wähle ein Workout aus", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            var dialog = new WorkoutDialog(_selectedWorkout);
            if (dialog.ShowDialog() == true)
            {
                _selectedWorkout.Name = dialog.WorkoutName;
                _selectedWorkout.Date = dialog.WorkoutDate;
                _workoutService.UpdateWorkout(_selectedWorkout);
                RefreshWorkoutsList();
                DisplayWorkoutDetails();
            }
        }

        private void DeleteWorkout_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedWorkout == null)
            {
                MessageBox.Show("Bitte wähle ein Workout aus", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            MessageBoxResult result = MessageBox.Show(
                $"Möchtest du das Workout '{_selectedWorkout.Name}' wirklich löschen?",
                "Bestätigung",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                _workoutService.DeleteWorkout(_selectedWorkout.Id);
                _selectedWorkout = null;
                RefreshWorkoutsList();
                DisplayWorkoutDetails();
            }
        }

        private void CompleteWorkout_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedWorkout == null)
            {
                MessageBox.Show("Bitte wähle ein Workout aus", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (_selectedWorkout.IsCompleted)
            {
                _workoutService.MarkAsOpen(_selectedWorkout.Id);
            }
            else
            {
                _workoutService.MarkAsCompleted(_selectedWorkout.Id);
            }

            _selectedWorkout = _workoutService.GetWorkoutById(_selectedWorkout.Id);
            RefreshWorkoutsList();
            DisplayWorkoutDetails();
        }

        private void AddExercise_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedWorkout == null)
            {
                MessageBox.Show("Bitte wähle ein Workout aus", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            var dialog = new ExerciseDialog();
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    var exercise = new Exercise(dialog.SelectedExerciseName, dialog.MuscleGroup);
                    foreach (var set in dialog.ResultSets)
                    {
                        exercise.Sets.Add(set);
                    }
                    
                    _selectedWorkout.Exercises.Add(exercise);
                    _workoutService.UpdateWorkout(_selectedWorkout);
                    DisplayWorkoutDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Hinzufügen der Übung: {ex.Message}", 
                        "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void EditExercise_Click(object sender, RoutedEventArgs e)
        {
            var exercise = (sender as FrameworkElement)?.DataContext as Exercise;
            if (exercise == null)
            {
                MessageBox.Show("Bitte wähle eine Übung aus", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            var dialog = new ExerciseDialog();
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    exercise.Name = dialog.SelectedExerciseName;
                    exercise.Muscle = dialog.MuscleGroup;
                    exercise.Sets.Clear();
                    foreach (var set in dialog.ResultSets)
                    {
                        exercise.Sets.Add(set);
                    }
                    
                    _workoutService.UpdateWorkout(_selectedWorkout);
                    DisplayWorkoutDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Bearbeiten der Übung: {ex.Message}", 
                        "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void DeleteExercise_Click(object sender, RoutedEventArgs e)
        {
            var exercise = (sender as FrameworkElement)?.DataContext as Exercise;
            if (exercise == null)
            {
                MessageBox.Show("Bitte wähle eine Übung aus", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            MessageBoxResult result = MessageBox.Show(
                $"Möchtest du die Übung '{exercise.Name}' wirklich löschen?",
                "Bestätigung",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                _selectedWorkout.Exercises.Remove(exercise);
                _workoutService.UpdateWorkout(_selectedWorkout);
                DisplayWorkoutDetails();
            }
        }
    }
}
