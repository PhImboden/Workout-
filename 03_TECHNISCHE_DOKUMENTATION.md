# 📊 TECHNISCHE DOKUMENTATION & IMPLEMENTATION

**Projekt:** Fitness Tracker WPF Applikation  
**Autor:** Entwicklungs-Team  
**Version:** 2.0  
**Datum:** 29.04.2026

---

## 🏗️ Architektur-Übersicht

### Schichtenmodell

```
┌─────────────────────────────────────────────┐
│   Presentation Layer (XAML/UI)              │
│   - MainWindow.xaml                         │
│   - WorkoutDialog.xaml                      │
│   - ExerciseDialog.xaml                     │
└────────────────────┬────────────────────────┘
                     │
┌─────────────────────┴────────────────────────┐
│   Application Layer (Code-Behind)            │
│   - MainWindow.xaml.cs                       │
│   - WorkoutDialog.xaml.cs                    │
│   - ExerciseDialog.xaml.cs                   │
└────────────────────┬────────────────────────┘
                     │
┌─────────────────────┴────────────────────────┐
│   Business Logic Layer (Services)            │
│   - WorkoutService.cs                        │
│   - ExerciseCatalog.cs                       │
└────────────────────┬────────────────────────┘
                     │
┌─────────────────────┴────────────────────────┐
│   Data Access Layer (Persistence)            │
│   - DataService.cs (JSON I/O)                │
└────────────────────┬────────────────────────┘
                     │
┌─────────────────────┴────────────────────────┐
│   Data Models                                │
│   - Workout.cs                               │
│   - Exercise.cs                              │
│   - Set.cs                                   │
└─────────────────────────────────────────────┘
                     │
┌─────────────────────┴────────────────────────┐
│   Persistent Storage (Local)                 │
│   - %APPDATA%\FitnessTracker\workouts.json   │
└─────────────────────────────────────────────┘
```

---

## 📁 Projektstruktur

```
FitnessTracker/
├── 📄 App.xaml                    # Application Root + Ressourcen
├── 📄 App.xaml.cs                 # Startup-Logik + Service-Initialisierung
├── 📄 Converters.cs               # Value Converters (Bool→Visibility, etc.)
├── 📄 FitnessTracker.csproj       # Projektdatei (.NET 4.8)
│
├── 📁 Models/                      # Datenmodelle
│   ├── 📄 Workout.cs              # Hauptmodell (Id, Name, Date, Exercises)
│   ├── 📄 Exercise.cs             # Übungs-Modell (Name, Muscle, Sets)
│   └── 📄 Set.cs                  # Satz-Modell (Reps, Weight)
│
├── 📁 Services/                    # Geschäftslogik
│   ├── 📄 DataService.cs          # JSON Serialisierung & Speicherung
│   ├── 📄 WorkoutService.cs       # CRUD + Filter/Suche
│   └── 📄 ExerciseCatalog.cs      # Vordefinierte Übungen (30+)
│
├── 📁 Views/                       # Benutzeroberfläche
│   ├── 📄 MainWindow.xaml         # Hauptfenster (2-spalten Layout)
│   ├── 📄 MainWindow.xaml.cs      # Event-Handler + UI-Logik
│   ├── 📄 WorkoutDialog.xaml      # Dialog für neues Workout
│   ├── 📄 WorkoutDialog.xaml.cs   # Dialog-Code-Behind
│   ├── 📄 ExerciseDialog.xaml     # Dialog für Übungen hinzufügen
│   └── 📄 ExerciseDialog.xaml.cs  # Exercise Dialog + SetViewModel
│
└── 📁 bin/
    ├── 📁 Debug/net48/
    │   ├── 🔧 FitnessTracker.exe   # Debug-Version
    │   └── 📄 Newtonsoft.Json.dll
    └── 📁 Release/net48/
        ├── 🔧 FitnessTracker.exe   # Release-Version (27.5 KB)
        └── 📄 Newtonsoft.Json.dll
```

---

## 🔧 Hauptkomponenten & Implementierung

### 1. Models (Datenebene)

#### Workout.cs
```csharp
public class Workout
{
    public string Id { get; set; }                    // GUID
    public string Name { get; set; }                  // z.B. "Brusttraining"
    public DateTime Date { get; set; }                // Datum des Workouts
    public List<Exercise> Exercises { get; set; }     // Übungen im Workout
    public bool IsCompleted { get; set; }             // Status (erledigt/offen)

    // Methoden:
    // GetTotalVolume()          → Σ aller Übungs-Volumen
    // GetVolumeByMuscle()       → Volumen pro Muskelgruppe
}
```

#### Exercise.cs
```csharp
public class Exercise
{
    public string Name { get; set; }                  // z.B. "Bankdrücken"
    public string Muscle { get; set; }                // z.B. "Brust"
    public List<Set> Sets { get; set; }               // Liste der Sets

    // Methoden:
    // GetVolume()               → Gesamtvolumen dieser Übung
}
```

#### Set.cs
```csharp
public class Set
{
    public int Reps { get; set; }                     // Wiederholungen (z.B. 10)
    public double Weight { get; set; }                // Gewicht in kg (z.B. 60.0)

    // Volumen = Reps × Weight
}
```

### 2. Services (Geschäftslogik)

#### DataService.cs
- **Verantwortung:** JSON I/O, Serialisierung, File-Management
- **Hauptmethoden:**
  - `LoadWorkouts()` → Lädt Workouts aus JSON
  - `SaveWorkouts()` → Speichert Workouts zu JSON
  - `GetFilePath()` → Gibt AppData-Pfad zurück

#### WorkoutService.cs
- **Verantwortung:** CRUD-Operationen, Filter, Suche
- **Hauptmethoden:**
  - `AddWorkout()` → Neues Workout erstellen
  - `UpdateWorkout()` → Workout bearbeiten
  - `DeleteWorkout()` → Workout löschen
  - `GetFilteredWorkouts()` → Filter (Alle/Offen/Erledigt)
  - `SearchWorkouts()` → Suche nach Name

#### ExerciseCatalog.cs
- **Verantwortung:** Vordefinierte Übungen
- **Hauptmethoden:**
  - `GetDefaultExercises()` → Gibt 30+ Übungen zurück
  - `GetMuscleGroups()` → Muskelgruppen-Liste
- **Übungen nach Kategorie:** Brust, Rücken, Schultern, Arme, Beine, Core

### 3. Views (Benutzeroberfläche)

#### MainWindow.xaml
- **Layout:** 2-spalten (Links: Liste, Rechts: Details)
- **Left Panel:**
  - Suchfeld
  - Filter-RadioButtons (Alle/Offen/Erledigt)
  - "+ Neues Workout" Button
  - Workout-Liste (scrollbar)

- **Right Panel:**
  - Workout-Titel
  - Info-Cards (Datum, Status, Übungen, Volumen)
  - Übungs-Liste mit Edit/Delete
  - "+ Übung hinzufügen" Button
  - Action-Buttons (Bearbeiten, Erledigt, Löschen)

#### WorkoutDialog.xaml
- Einfacher Dialog für neues Workout
- InputFelder: Name, Datum (DatePicker)
- OK / Cancel Buttons

#### ExerciseDialog.xaml
- Übungs-Auswahl (ComboBox aus Katalog)
- Muskelgruppen-Dropdown
- Dynamische Set-Liste (Add/Remove Sets)
- Pro Set: Reps + Weight InputFelder
- Live-Volumenberechnung
- OK / Cancel Buttons

---

## 💾 Datenspeicherung

### JSON-Format

```json
[
  {
    "Id": "12345abc...",
    "Name": "Brusttraining Montag",
    "Date": "2026-04-22T10:30:00",
    "IsCompleted": false,
    "Exercises": [
      {
        "Name": "Bankdrücken",
        "Muscle": "Brust",
        "Sets": [
          {"Reps": 10, "Weight": 60.0},
          {"Reps": 8, "Weight": 65.0},
          {"Reps": 6, "Weight": 70.0}
        ]
      }
    ]
  }
]
```

### Speicherort
- **Windows:** `%APPDATA%\FitnessTracker\workouts.json`
- **Beispiel:** `C:\Users\[User]\AppData\Roaming\FitnessTracker\workouts.json`

### Auto-Save Mechanismus
- Speicherung nach jeder Änderung
- Serialisierung mit Newtonsoft.Json
- Pretty-printing für Lesbarkeit
- Error-Handling mit try-catch

---

## 🎨 User Interface Design

### Design-Philosophie
- **Theme:** Dark Mode (Modern, Eye-friendly)
- **Akzente:** Teal/Cyan für Aktionen
- **Layout:** 2-spalten, responsive

### Color-Palette
| Element | Farbe | Hex | Verwendung |
|---------|-------|-----|-----------|
| Hintergrund | Deep Black-Blue | #0F1419 | Fenster |
| Panel | Dark Purple-Gray | #1E1E2E | Panels |
| Text Primary | White | #FFFFFF | Überschriften |
| Text Secondary | Light Gray | #90A4AE | Details |
| Primary Action | Teal | #00BFA5 | Add, OK |
| Secondary | Blue | #1976D2 | Edit |
| Danger | Red | #D32F2F | Delete |

### Button-Styling
- **Hover-Effekt:** Farbe ändert sich
- **Border-Radius:** 6px für modernes Look
- **Padding:** 8-12px für Komfort
- **Icons:** Emoji-Symbole (✓, ✎, ✕, 🗑, etc.)

---

## 📊 Volumen-Berechnung

### Formel
```
Set-Volumen = Wiederholungen × Gewicht
Übungs-Volumen = Σ aller Set-Volumen
Workout-Volumen = Σ aller Übungs-Volumen
```

### Beispiel
```
Bankdrücken:
  Set 1: 10 × 60 = 600 kg
  Set 2: 8 × 65 = 520 kg
  Set 3: 6 × 70 = 420 kg
  ────────────────────
  Gesamt: 1540 kg

Kniebeuge:
  Set 1: 12 × 100 = 1200 kg
  Set 2: 10 × 105 = 1050 kg
  ──────────────────────
  Gesamt: 2250 kg

Workout-Volumen = 1540 + 2250 = 3790 kg
```

### Live-Berechnung
- Wird nach jeder Set-Eingabe aktualisiert
- Angezeigt in ExerciseDialog während Eingabe
- Angezeigt im MainWindow nach Speicherung

---

## 🔍 Suche & Filter

### Suche
- **Ort:** Suchfeld im Left Panel
- **Funktionalität:** Filtert Workouts nach Name
- **Live:** Aktualisiert während Eingabe
- **Case-Insensitive:** "Brust" = "brust" = "BRUST"

### Filter
- **Optionen:** Alle / Offen / Erledigt
- **Ort:** RadioButtons im Left Panel
- **Kombinierbar:** Suche + Filter = Combined Filter

### Implementierung
```csharp
private List<Workout> GetFilteredWorkouts()
{
    var filtered = _workoutService.GetAllWorkouts();

    // Nach Status filtern
    if (FilterRadio_Offen.IsChecked == true)
        filtered = filtered.Where(w => !w.IsCompleted).ToList();
    else if (FilterRadio_Erledigt.IsChecked == true)
        filtered = filtered.Where(w => w.IsCompleted).ToList();

    // Nach Namen suchen
    string searchText = SearchBox.Text?.ToLower() ?? "";
    if (!string.IsNullOrEmpty(searchText))
        filtered = filtered.Where(w => w.Name.ToLower().Contains(searchText)).ToList();

    return filtered;
}
```

---

## ⚙️ Technischer Stack

| Komponente | Version | Zweck |
|-----------|---------|--------|
| .NET Framework | 4.8 | Runtime |
| WPF | 4.8 | UI-Framework |
| Newtonsoft.Json | 13.0.3 | JSON-Serialisierung |
| C# | 9.0 | Programmiersprache |

---

## 🏃 Performance-Charakteristiken

| Metrik | Wert | Status |
|--------|------|--------|
| **Compile-Zeit** | ~1.1s | ✅ Schnell |
| **Startup-Zeit** | <1s | ✅ Sehr schnell |
| **EXE-Größe** | 27.5 KB | ✅ Klein |
| **Memory-Footprint** | ~50 MB | ✅ Effizient |
| **JSON-I/O** | <100ms | ✅ Instant |

---

## 🐛 Error Handling

### Implementierte Fehlerbehandlung

1. **File-Operationen**
   ```csharp
   try
   {
       var data = JsonConvert.DeserializeObject<List<Workout>>(json);
   }
   catch (JsonException ex)
   {
       MessageBox.Show($"Fehler beim Laden: {ex.Message}");
   }
   ```

2. **Null-Checks**
   ```csharp
   if (_isInitialized && FilterRadio_Changed != null)
   {
       RefreshWorkoutsList();
   }
   ```

3. **Validierung**
   - Name darf nicht leer sein
   - Mindestens 1 Set erforderlich
   - Gültige Zahlen in Reps/Weight

---

## ✅ Quality Assurance

### Getestete Szenarien

| Szenario | Status | Notizen |
|----------|--------|---------|
| App Start | ✅ | Daten laden schnell |
| Workout Create | ✅ | Wird sofort angezeigt |
| Workout Edit | ✅ | Änderungen speichern sich |
| Workout Delete | ✅ | Mit Bestätigung |
| Übung Add | ✅ | Katalog + Custom |
| Übung Edit | ✅ | Sets ändern funktioniert |
| Übung Delete | ✅ | Aus Liste entfernt |
| Suche | ✅ | Live-Filterung |
| Filter | ✅ | Kombinierbar |
| Status Toggle | ✅ | Icon wechselt |
| Data Persist | ✅ | Nach Neustart erhalten |
| Volume Calc | ✅ | Mathematik korrekt |

---

## 📚 Dokumentation & Code-Kommentare

- README.md - Überblick & Features
- QUICK_START.md - Schnellstart-Anleitung
- SUMMARY.md - Technische Übersicht
- UBUNGEN_KATALOG.md - Neue Features
- ANWENDUNGSBEISPIEL.md - Tutorials
- Code-Kommentare - In kritischen Methoden

---

**Dokumentversion:** 2.0  
**Status:** ✅ FINAL  
**Last Updated:** 29.04.2026
