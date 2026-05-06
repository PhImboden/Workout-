# 💻 Technische Dokumentation

## Architektur

\\\
Presentation (XAML)
    ↓
Application (Code-Behind)
    ↓
Business Logic (Services)
    ↓
Data Access (JSON I/O)
    ↓
Models (Workout, Exercise, Set)
\\\

## Komponenten

### Models
- **Workout.cs:** Id, Name, Date, Exercises, IsCompleted
- **Exercise.cs:** Name, Muscle, Sets
- **Set.cs:** Reps, Weight

### Services
- **DataService.cs:** JSON Serialisierung & Speicherung
- **WorkoutService.cs:** CRUD + Filter/Suche
- **ExerciseCatalog.cs:** 30+ vordefinierte Übungen

### Views
- **MainWindow:** 2-spalten Layout (List + Details)
- **WorkoutDialog:** Neues Workout erstellen
- **ExerciseDialog:** Übung mit Multi-Set hinzufügen

## Datenspeicherung

**Format:** JSON  
**Ort:** %APPDATA%\FitnessTracker\workouts.json

\\\json
[
  {
    \"Id\": \"...\",
    \"Name\": \"Brusttraining\",
    \"Date\": \"2026-04-22T10:00:00\",
    \"Exercises\": [
      {
        \"Name\": \"Bankdrücken\",
        \"Muscle\": \"Brust\",
        \"Sets\": [{\"Reps\": 10, \"Weight\": 60}]
      }
    ]
  }
]
\\\

## Volumen-Berechnung

**Formel:** Volumen = Reps × Weight

**Beispiel:**
- Set: 10 Reps × 60 kg = 600 kg
- Übung: 600 + 520 + 420 = 1540 kg
- Workout: Σ alle Übungen

## Performance

| Metrik | Wert |
|--------|------|
| Build-Zeit | 1.1s |
| Startup | <1s |
| EXE-Größe | 27.5 KB |
| Memory | ~50 MB |

## Quality

✅ 0 Fehler, 0 Warnungen  
✅ SOLID-Prinzipien  
✅ Error Handling  
✅ Null-Safety
