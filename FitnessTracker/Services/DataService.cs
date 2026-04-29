using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using FitnessTracker.Models;

namespace FitnessTracker.Services
{
    public class DataService
    {
        private readonly string _dataPath;
        private readonly string _workoutsFile;

        public DataService(string baseDir = null)
        {
            _dataPath = baseDir ?? Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "FitnessTracker");

            _workoutsFile = Path.Combine(_dataPath, "workouts.json");

            // Verzeichnis erstellen, falls nicht vorhanden
            if (!Directory.Exists(_dataPath))
                Directory.CreateDirectory(_dataPath);
        }

        public List<Workout> LoadWorkouts()
        {
            try
            {
                if (!File.Exists(_workoutsFile))
                    return new List<Workout>();

                string json = File.ReadAllText(_workoutsFile);
                return JsonConvert.DeserializeObject<List<Workout>>(json) ?? new List<Workout>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Fehler beim Laden der Workouts: {ex.Message}");
                return new List<Workout>();
            }
        }

        public void SaveWorkouts(List<Workout> workouts)
        {
            try
            {
                string json = JsonConvert.SerializeObject(workouts, Formatting.Indented);
                File.WriteAllText(_workoutsFile, json);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Fehler beim Speichern der Workouts: {ex.Message}");
            }
        }

        public void SaveWorkout(Workout workout, List<Workout> allWorkouts)
        {
            try
            {
                var existing = allWorkouts.FirstOrDefault(w => w.Id == workout.Id);
                if (existing != null)
                {
                    allWorkouts.Remove(existing);
                }
                allWorkouts.Add(workout);
                SaveWorkouts(allWorkouts);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Fehler beim Speichern eines Workouts: {ex.Message}");
            }
        }

        public void DeleteWorkout(string workoutId, List<Workout> allWorkouts)
        {
            try
            {
                var workout = allWorkouts.FirstOrDefault(w => w.Id == workoutId);
                if (workout != null)
                {
                    allWorkouts.Remove(workout);
                    SaveWorkouts(allWorkouts);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Fehler beim Löschen eines Workouts: {ex.Message}");
            }
        }
    }
}
