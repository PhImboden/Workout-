# 🏗️ Technical Documentation

## Architecture

**3-Layer Model:**
- **Presentation:** XAML UI (MainWindow, Dialogs)
- **Business Logic:** WorkoutService, ExerciseCatalog
- **Data Access:** DataService (JSON I/O)

## Database Schema (JSON)

**Workout Object:**
\\\json
{
  "Id": "guid",
  "Name": "Chest Day",
  "Date": "2026-04-29",
  "IsCompleted": true,
  "Exercises": [...]
}
\\\

**Exercise Object:**
\\\json
{
  "Name": "Bench Press",
  "MuscleGroup": "Chest",
  "Sets": [{"Reps": 10, "Weight": 80}]
}
\\\

## Key Classes

| Class | Responsibility |
|-------|-----------------|
| WorkoutService | CRUD operations |
| ExerciseCatalog | 30+ predefined exercises |
| DataService | JSON load/save |
| Converters | Data binding |

## Storage

- **Location:** %APPDATA%\FitnessTracker\workouts.json
- **Format:** UTF-8 JSON
- **Persistence:** Auto-save on changes

## Dependencies

- Newtonsoft.Json 13.0.3 (JSON parsing)
- .NET Framework 4.8 (Windows only)
