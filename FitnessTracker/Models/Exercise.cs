using System;
using System.Collections.Generic;

namespace FitnessTracker.Models
{
    public class Exercise
    {
        public string Name { get; set; }
        public string Muscle { get; set; } // z.B. "Brust", "Rücken", etc.
        public List<Set> Sets { get; set; } = new List<Set>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Exercise() { }

        public Exercise(string name, string muscle = "")
        {
            Name = name;
            Muscle = muscle;
        }

        public double GetVolume()
        {
            double volume = 0;
            foreach (var set in Sets)
            {
                volume += set.Reps * set.Weight;
            }
            return volume;
        }
    }
}
