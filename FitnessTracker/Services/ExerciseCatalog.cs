using System.Collections.Generic;
using FitnessTracker.Models;

namespace FitnessTracker.Services
{
    /// <summary>
    /// Vordefinierte Katalog mit Standard-Übungen nach Muskelgruppen
    /// </summary>
    public static class ExerciseCatalog
    {
        public static List<Exercise> GetDefaultExercises()
        {
            return new List<Exercise>
            {
                // Brust
                new Exercise("Bankdrücken", "Brust"),
                new Exercise("Schrägbankdrücken", "Brust"),
                new Exercise("Hantelflüge", "Brust"),
                new Exercise("Kabelflüge", "Brust"),

                // Rücken
                new Exercise("Kreuzheben", "Rücken"),
                new Exercise("Latzug", "Rücken"),
                new Exercise("Rudermaschine", "Rücken"),
                new Exercise("Langhantelrudern", "Rücken"),
                new Exercise("Kurzhantelrudern", "Rücken"),

                // Schultern
                new Exercise("Schulterpresse", "Schultern"),
                new Exercise("Schulterdrücken", "Schultern"),
                new Exercise("Seitenheben", "Schultern"),
                new Exercise("Frontheben", "Schultern"),
                new Exercise("Reißen", "Schultern"),

                // Arme
                new Exercise("Langhantelcurls", "Bizeps"),
                new Exercise("Kurzhantelcurls", "Bizeps"),
                new Exercise("Kabelcurls", "Bizeps"),
                new Exercise("Trizepsdips", "Trizeps"),
                new Exercise("Trizepsdrücken", "Trizeps"),
                new Exercise("Kopfüberzug", "Trizeps"),

                // Beine
                new Exercise("Kniebeuge", "Beine"),
                new Exercise("Beinpresse", "Beine"),
                new Exercise("Beinstrecker", "Beine"),
                new Exercise("Beincurl", "Beine"),
                new Exercise("Beinheben", "Beine"),
                new Exercise("Legpress", "Beine"),

                // Core/Bauch
                new Exercise("Crunches", "Bauch"),
                new Exercise("Sit-ups", "Bauch"),
                new Exercise("Planks", "Bauch"),
                new Exercise("Beinheben hängend", "Bauch"),

                // Allgemein
                new Exercise("Liegestütze", "Brust"),
                new Exercise("Dips", "Brust"),
                new Exercise("Klimmzüge", "Rücken"),
            };
        }

        public static List<string> GetMuscleGroups()
        {
            return new List<string>
            {
                "Brust",
                "Rücken",
                "Schultern",
                "Bizeps",
                "Trizeps",
                "Beine",
                "Bauch",
                "Sonstiges"
            };
        }
    }
}
