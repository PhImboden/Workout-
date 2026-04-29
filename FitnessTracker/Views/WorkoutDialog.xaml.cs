using System;
using System.Windows;
using FitnessTracker.Models;

namespace FitnessTracker.Views
{
    public partial class WorkoutDialog : Window
    {
        public string WorkoutName { get; private set; }
        public DateTime WorkoutDate { get; private set; }

        public WorkoutDialog()
        {
            InitializeComponent();
            DatePicker.SelectedDate = DateTime.Now;
        }

        public WorkoutDialog(Workout workout) : this()
        {
            NameTextBox.Text = workout.Name;
            DatePicker.SelectedDate = workout.Date;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Bitte gib einen Workout-Namen ein", "Validierungsfehler", 
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            WorkoutName = NameTextBox.Text.Trim();
            WorkoutDate = DatePicker.SelectedDate ?? DateTime.Now;
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
