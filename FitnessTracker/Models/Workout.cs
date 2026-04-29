using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessTracker.Models
{
    public class Workout
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Workout()
        {
            Id = Guid.NewGuid().ToString();
        }

        public Workout(string name, DateTime? date = null)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Date = date ?? DateTime.Now;
        }

        public double GetTotalVolume()
        {
            return Exercises.Sum(e => e.GetVolume());
        }

        public Dictionary<string, double> GetVolumeByMuscle()
        {
            var volumeByMuscle = new Dictionary<string, double>();
            foreach (var exercise in Exercises)
            {
                if (!volumeByMuscle.ContainsKey(exercise.Muscle))
                    volumeByMuscle[exercise.Muscle] = 0;
                volumeByMuscle[exercise.Muscle] += exercise.GetVolume();
            }
            return volumeByMuscle;
        }
    }
}
