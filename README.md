# 💪 Fitness Tracker - WPF Applikation

Eine benutzerfreundliche Desktop-Applikation zum Erstellen, Verwalten und Verfolgen von Workouts mit lokaler JSON-Speicherung.

## 🎯 Features

### Implementiert ✅
- **Workout-Management**
  - ✅ Workout erstellen mit Name und Datum
  - ✅ Workout bearbeiten
  - ✅ Workout löschen
  - ✅ Workout als erledigt markieren

- **Übungen & Sätze**
  - ✅ Übungen pro Workout verwalten
  - ✅ Sätze mit Wiederholungen & Gewicht
  - ✅ Volumen-Berechnung (Reps × Weight)
  - ✅ **Vordefinierter Übungskatalog** (30+ Übungen nach Muskelgruppen)
  - ✅ **Schnelle Übungsauswahl** aus Katalog oder benutzerdefiniert
  - ✅ **Multi-Set Input** - Mehrere Sets mit individuellen Werten pro Übung
  - ✅ **Live-Volumenberechnung** während der Eingabe
  - ✅ **Übungsbearbeitung** - Edit/Delete Funktionalität

- **Suche & Filter**
  - ✅ Suche nach Workout-Namen und Datum
  - ✅ Filter: Alle / Offen / Erledigt
  - ✅ Live-Suchfilterung

- **Datenverwaltung**
  - ✅ Automatisches Speichern in JSON
  - ✅ Daten beim App-Start laden
  - ✅ AppData-Verzeichnis-Speicherung

- **Benutzeroberfläche**
  - ✅ Modernes 2-spalten Layout
  - ✅ Workout-Details-Ansicht
  - ✅ Farbcodierung (erledigt = Häkchen)
  - ✅ Responsive Design

## 🚀 Installation & Start

### Voraussetzungen
- .NET Framework 4.8+
- Windows 7+

### Kompilierung
```bash
cd FitnessTracker
dotnet build
```

### Ausführung
```bash
dotnet run --project FitnessTracker
# oder direkt die EXE starten:
FitnessTracker/bin/Debug/net48/FitnessTracker.exe
```

## 📁 Projektstruktur

```
FitnessTracker/
├── Models/
│   ├── Workout.cs          # Workout-Modell mit Übungen
│   ├── Exercise.cs         # Übungs-Modell mit Sets
│   └── Set.cs              # Satz-Modell (Reps + Weight)
├── Services/
│   ├── DataService.cs      # JSON I/O & Serialisierung
│   └── WorkoutService.cs   # Business Logic
├── Views/
│   ├── MainWindow.xaml     # Hauptfenster UI
│   ├── MainWindow.xaml.cs  # Code-Behind
│   ├── WorkoutDialog.xaml  # Dialog für neues Workout
│   └── WorkoutDialog.xaml.cs
├── Converters.cs           # Value Converters (UI)
├── App.xaml                # Application Root
├── App.xaml.cs             # Startup-Logik
└── FitnessTracker.csproj  # Projektdatei
```

## 💾 Datenspeicherung

Daten werden als **JSON** gespeichert:
- **Location:** `%APPDATA%\FitnessTracker\workouts.json`
- **Format:** Pretty-geprinted JSON für einfache Bearbeitung
- **Automatisches Speichern** nach jeder Änderung

### Beispiel-JSON:
```json
[
  {
    "Id": "abc123...",
    "Name": "Brusttraining",
    "Date": "2026-04-22T10:00:00",
    "IsCompleted": false,
    "Exercises": [
      {
        "Name": "Bankdrücken",
        "Muscle": "Brust",
        "Sets": [
          {"Reps": 10, "Weight": 100},
          {"Reps": 8, "Weight": 110}
        ]
      }
    ]
  }
]
```

## 🎮 Bedienung

### Neues Workout
1. Klick auf **"+ Neues Workout"** Button
2. Name eingeben
3. Datum setzen
4. OK klicken

### Übung hinzufügen (NEU!)
1. Workout auswählen
2. **"+ Übung hinzufügen"** Button klicken
3. **Im Dialog:**
   - **Übung wählen:** Aus dem Katalog (30+ Übungen) oder eigene eingeben
   - **Muskelgruppe:** Automatisch gesetzt oder manuell anpassen
   - **Sets hinzufügen:** 
     - Pro Set: Wiederholungen und Gewicht eingeben
     - "Set hinzufügen" für weitere Sets
     - Volumen wird live berechnet
4. OK klicken → **Übung ist im Workout und wird automatisch gespeichert**

### Übung bearbeiten/löschen (NEU!)
1. Workout auswählen
2. Bei der gewünschten Übung:
   - **"✎ Bearbeiten"** - Sets ändern
   - **"✕ Löschen"** - Übung entfernen

### Workout bearbeiten
1. Workout in der Liste auswählen
2. **"✎ Bearbeiten"** klicken
3. Name/Datum ändern
4. Speichern

### Workout löschen
1. Workout auswählen
2. **"🗑 Löschen"** klicken
3. Bestäung akzeptieren

### Workout als erledigt
1. Workout auswählen
2. **"✓ Erledigt"** klicken
3. Status ändert sich automatisch

## 🔧 Technologie-Stack

- **Framework:** .NET Framework 4.8
- **UI:** WPF (Windows Presentation Foundation)
- **Serialisierung:** Newtonsoft.Json (13.0.3)
- **Speicher:** JSON-Dateien (lokal)

## 📊 Unterstützte User Stories

### Hoch-Priorität ✅
- [x] Workout erstellen
- [x] Workout löschen
- [x] Workout bearbeiten
- [x] Alle Workouts anzeigen
- [x] Daten beim Start laden
- [x] Daten automatisch speichern
- [x] Sätze erfassen
- [x] Wiederholungen erfassen
- [x] Gewicht eingeben
- [x] Datum setzen
- [x] Workout als erledigt markieren
- [x] Fehlermeldungen anzeigen
- [x] Einfache Benutzeroberfläche
- [x] Buttons für Aktionen

### Mittel-Priorität ✅
- [x] Vergangene Workouts ansehen
- [x] Erledigte Workouts erkennen
- [x] Suche nach Workouts
- [x] **Vordefinierte Übungskatalog** (NEU!)
- [x] **Übungsauswahl aus Katalog** (NEU!)
- [x] **Multi-Set Input** (NEU!)
- [x] **Live-Volumenberechnung** (NEU!)

## 📚 Dokumentation

- **[QUICK_START.md](QUICK_START.md)** - Schnelleinstieg
- **[UBUNGEN_KATALOG.md](UBUNGEN_KATALOG.md)** - Detailliert: Übungskatalog & Set-Management
- **[ANWENDUNGSBEISPIEL.md](ANWENDUNGSBEISPIEL.md)** - Schritt-für-Schritt Beispiele
- **[SUMMARY.md](SUMMARY.md)** - Technische Zusammenfassung
- **[CHECKLIST.md](CHECKLIST.md)** - QA & Release-Checklist
- **[INDEX.md](INDEX.md)** - Dokumentations-Index

## 📝 Beispiel-Workout

```
Brusttraining Montag (22.04.2026)
Status: Offen
Gesamtvolumen: 3785 kg

├─ Bankdrücken (Brust)
│  ├─ Satz 1: 10 × 60 kg = 600 kg
│  ├─ Satz 2: 8 × 65 kg = 520 kg
│  ├─ Satz 3: 6 × 70 kg = 420 kg
│  └─ Volumen: 1540 kg
│
├─ Schrägbankdrücken (Brust)
│  ├─ Satz 1: 12 × 50 kg = 600 kg
│  ├─ Satz 2: 10 × 55 kg = 550 kg
│  └─ Volumen: 1150 kg
│
├─ Hantelflüge (Brust)
│  ├─ Satz 1: 12 × 30 kg = 360 kg
│  ├─ Satz 2: 12 × 30 kg = 360 kg
│  └─ Volumen: 720 kg
│
└─ Kabelflüge (Brust)
   ├─ Satz 1: 15 × 25 kg = 375 kg
   └─ Volumen: 375 kg
```

## 🎓 Übungskatalog-Kategorien

**30+ vordefinierte Übungen nach Muskelgruppen:**
- 💪 **Brust:** Bankdrücken, Schrägbankdrücken, Hantelflüge, Kabelflüge, ...
- 🔙 **Rücken:** Kreuzheben, Latzug, Rudermaschine, ...
- 🤸 **Schultern:** Schulterpresse, Seitenheben, ...
- 💪 **Bizeps:** Langhantelcurls, Kurzhantelcurls, ...
- 🤛 **Trizeps:** Trizepsdips, Trizepsdrücken, ...
- 🦵 **Beine:** Kniebeuge, Beinpresse, Beinstrecker, ...
- 🏋️ **Bauch:** Crunches, Planks, Situps, ...

**Oder:** Erstelle deine eigenen Übungen mit benutzerdefinierten Namen!
