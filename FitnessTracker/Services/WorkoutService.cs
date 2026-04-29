using System;
using System.Collections.Generic;
using System.Linq;
using FitnessTracker.Models;

namespace FitnessTracker.Services
{
    public class WorkoutService
    {
        private List<Workout> _workouts;
        private readonly DataService _dataService;

        public WorkoutService(DataService dataService)
        {
            _dataService = dataService;
            _workouts = _dataService.LoadWorkouts();
        }

        public List<Workout> GetAllWorkouts()
        {
            return _workouts;
        }

        public List<Workout> GetOpenWorkouts()
        {
            return _workouts.Where(w => !w.IsCompleted).ToList();
        }

        public List<Workout> GetCompletedWorkouts()
        {
            return _workouts.Where(w => w.IsCompleted).ToList();
        }

        public Workout CreateWorkout(string name, DateTime? date = null)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Workout-Name darf nicht leer sein");

            var workout = new Workout(name, date);
            _workouts.Add(workout);
            _dataService.SaveWorkouts(_workouts);
            return workout;
        }

        public void UpdateWorkout(Workout workout)
        {
            var existing = _workouts.FirstOrDefault(w => w.Id == workout.Id);
            if (existing != null)
            {
                _workouts[_workouts.IndexOf(existing)] = workout;
                _dataService.SaveWorkouts(_workouts);
            }
        }

        public void DeleteWorkout(string workoutId)
        {
            _workouts.RemoveAll(w => w.Id == workoutId);
            _dataService.SaveWorkouts(_workouts);
        }

        public Workout GetWorkoutById(string id)
        {
            return _workouts.FirstOrDefault(w => w.Id == id);
        }

        public List<Workout> SearchWorkouts(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return _workouts;

            return _workouts.Where(w => 
                w.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                w.Date.ToString("dd.MM.yyyy").Contains(searchTerm)
            ).ToList();
        }

        public List<Workout> GetWorkoutsByMuscle(string muscle)
        {
            return _workouts.Where(w => 
                w.Exercises.Any(e => e.Muscle.Equals(muscle, StringComparison.OrdinalIgnoreCase))
            ).ToList();
        }

        public void AddExercise(string workoutId, Exercise exercise)
        {
            var workout = GetWorkoutById(workoutId);
            if (workout != null)
            {
                workout.Exercises.Add(exercise);
                UpdateWorkout(workout);
            }
        }

        public void RemoveExercise(string workoutId, string exerciseName)
        {
            var workout = GetWorkoutById(workoutId);
            if (workout != null)
            {
                workout.Exercises.RemoveAll(e => e.Name == exerciseName);
                UpdateWorkout(workout);
            }
        }

        public void MarkAsCompleted(string workoutId)
        {
            var workout = GetWorkoutById(workoutId);
            if (workout != null)
            {
                workout.IsCompleted = true;
                UpdateWorkout(workout);
            }
        }

        public void MarkAsOpen(string workoutId)
        {
            var workout = GetWorkoutById(workoutId);
            if (workout != null)
            {
                workout.IsCompleted = false;
                UpdateWorkout(workout);
            }
        }
    }
}
