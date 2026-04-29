using System.Windows;
using FitnessTracker.Services;

namespace FitnessTracker
{
    public partial class App : Application
    {
        public static DataService DataService { get; private set; }
        public static WorkoutService WorkoutService { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Services initialisieren
            DataService = new DataService();
            WorkoutService = new WorkoutService(DataService);
        }
    }
}
