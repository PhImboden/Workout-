using System;

namespace FitnessTracker.Models
{
    public class Set
    {
        public int Reps { get; set; }
        public double Weight { get; set; } // in kg
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Set() { }

        public Set(int reps, double weight = 0)
        {
            Reps = reps;
            Weight = weight;
        }
    }
}
