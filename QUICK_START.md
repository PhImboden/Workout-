# 🚀 Fitness Tracker - Quick Start

## Installation (30 Sekunden)

### 1️⃣ Öffne PowerShell und navigiere zum Projekt:
```powershell
cd C:\Users\Philipp Imboden\source\repos\Workout-
```

### 2️⃣ Starten Sie die Applikation:
```powershell
dotnet run --project FitnessTracker
```

**ODER** Doppelklick auf die .EXE:
```
FitnessTracker\bin\Release\net48\FitnessTracker.exe
```

---

## 🎮 Erste Schritte

### 1. Erstes Workout erstellen
```
1. Klick: "+ Neues Workout" Button (grün)
2. Eingabe: "Mein erstes Training"
3. Klick: OK
```

### 2. Workout ansehen
```
1. Klick auf Workout in der linken Liste
2. Rechts werden Details angezeigt
```

### 3. Workout bearbeiten
```
1. Workout auswählen
2. Klick: "✎ Bearbeiten"
3. Name/Datum ändern
4. OK klicken
```

### 4. Workout löschen
```
1. Workout auswählen
2. Klick: "🗑 Löschen"
3. Bestätigung akzeptieren
```

### 5. Workout als erledigt markieren
```
1. Workout auswählen
2. Klick: "✓ Erledigt"
3. Status ändert sich zu "↻ Zurück öffnen"
```

### 6. Nach Workouts suchen
```
1. Gib einen Namen in die Suchbox ein
2. Liste wird live gefiltert
3. Leeren = alle Workouts
```

### 7. Nach Status filtern
```
Radio-Buttons links:
- "Alle" = alle Workouts
- "Offen" = nur nicht erledigte
- "Erledigt" = nur erledigte
```

---

## 📁 Wo sind meine Daten?

Die Daten werden automatisch hier gespeichert:
```
C:\Users\Philipp Imboden\AppData\Roaming\FitnessTracker\workouts.json
```

Sie können die Datei manuell öffnen und bearbeiten (JSON-Format).

---

## ⚙️ Projekt kompilieren (selbst)

### Requirement:
- .NET SDK 4.8 oder höher

### Kompilieren:
```powershell
cd FitnessTracker
dotnet build
```

### Release-Build:
```powershell
dotnet build -c Release
```

### Bereinigen & neu bauen:
```powershell
dotnet clean
dotnet build
```

---

## 🐛 Fehlerbehandlung

### Problem: "Applikation startet nicht"
```powershell
# Lösung: Sauberer Build
dotnet clean
dotnet build
dotnet run --project FitnessTracker
```

### Problem: "Daten sind weg"
- Überprüfe: `C:\Users\...\AppData\Roaming\FitnessTracker\workouts.json`
- Falls nicht vorhanden: App erstellt es beim nächsten Speichern

### Problem: "Converter-Fehler"
- Projekt neu starten
- Cache löschen: `rm -r obj bin`
- Neu bauen: `dotnet build`

---

## 📊 Dateistruktur nach Build

```
FitnessTracker/
├── bin/
│   ├── Debug/net48/
│   │   ├── FitnessTracker.exe          ← Starten Sie das!
│   │   ├── FitnessTracker.pdb
│   │   ├── Newtonsoft.Json.dll
│   │   └── FitnessTracker.exe.config
│   └── Release/net48/
│       └── (gleich wie Debug)
├── obj/                                 ← Build-Artefakte
├── Models/                              ← Datenmodelle
│   ├── Workout.cs
│   ├── Exercise.cs
│   └── Set.cs
├── Services/                            ← Geschäftslogik
│   ├── DataService.cs
│   └── WorkoutService.cs
├── Views/                               ← UI (XAML)
│   ├── MainWindow.xaml
│   ├── MainWindow.xaml.cs
│   ├── WorkoutDialog.xaml
│   └── WorkoutDialog.xaml.cs
├── App.xaml                             ← App Root
├── App.xaml.cs
├── Converters.cs                        ← Value Converters
└── FitnessTracker.csproj               ← Projektdatei
```

---

## 🔗 Weitere Ressourcen

- [README.md](README.md) - Vollständige Dokumentation
- [KORREKTUR_PROTOKOLL.md](KORREKTUR_PROTOKOLL.md) - Build-Fehlerbehandlung
- [.NET Framework Docs](https://docs.microsoft.com/de-de/dotnet/)
- [WPF Tutorial](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/)

---

## ✅ Checkliste - Alles funktioniert?

- [ ] App startet ohne Fehler
- [ ] Kann Workout erstellen
- [ ] Kann Workout bearbeiten
- [ ] Kann Workout löschen
- [ ] Suche funktioniert
- [ ] Filter funktioniert
- [ ] Daten werden gespeichert (JSON)
- [ ] Status-Markierung funktioniert
- [ ] Fenster-Layout ist übersichtlich

---

**🎉 Viel Spaß mit der Fitness Tracker Applikation!**

Für Fragen oder Probleme: Siehe KORREKTUR_PROTOKOLL.md
