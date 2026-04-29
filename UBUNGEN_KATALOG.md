# Übungs-Katalog und Set-Management - Implementation

## Überblick

Die aktuelle Implementierung ermöglicht nun:

1. **Vordefinierte Übungskatalog** - Ein standardisierter Katalog mit über 30 gängigen Fitness-Übungen
2. **Übungsauswahl** - Auswahl aus dem Katalog oder Eingabe einer benutzerdefinierten Übung
3. **Set-Management** - Pro Übung können mehrere Sets mit individuellen Wiederholungen und Gewichten eingegeben werden
4. **Volumenberechnung** - Das Gesamtvolumen wird automatisch berechnet (Wiederholungen × Gewicht)
5. **Workout-Integration** - Übungen können im Laufe eines Workouts hinzugefügt, bearbeitet oder gelöscht werden

## Neue Komponenten

### 1. ExerciseCatalog.cs
**Pfad:** `FitnessTracker/Services/ExerciseCatalog.cs`

Ein statischer Service, der:
- Eine vordefinierte Liste von 30+ Standardübungen bereitstellt
- Übungen nach Muskelgruppen kategorisiert:
  - Brust (Bankdrücken, Schrägbankdrücken, etc.)
  - Rücken (Kreuzheben, Latzug, etc.)
  - Schultern (Schulterpresse, Seitenheben, etc.)
  - Bizeps (Hantelcurls, Kabelcurls, etc.)
  - Trizeps (Trizepsdips, Trizepsdrücken, etc.)
  - Beine (Kniebeuge, Beinpresse, Beincurl, etc.)
  - Bauch (Crunches, Planks, etc.)
- Muskelgruppenlisten zum Filtern bereitstellt

**Hauptmethoden:**
- `GetDefaultExercises()` - Gibt die Liste aller vordefinierten Übungen zurück
- `GetMuscleGroups()` - Gibt die Liste aller Muskelgruppen zurück

### 2. ExerciseDialog.xaml / ExerciseDialog.xaml.cs
**Pfad:** 
- `FitnessTracker/Views/ExerciseDialog.xaml`
- `FitnessTracker/Views/ExerciseDialog.xaml.cs`

Ein Modal-Dialog, der:
- Übungs-Auswahl aus dem Katalog oder benutzerdefiniierte Übung ermöglicht
- Muskelgruppen-Auswahl bietet
- **Set-Management:**
  - Anzahl der Sets hinzufügen/entfernen
  - Pro Set: Wiederholungen und Gewicht eingeben
  - Echtzeitberechnung des Gesamtvolumens
- Validierung aller Eingaben sichert
- Ergebnis mit Übungsname, Muskelgruppe und Sets zurückgibt

**Besonderheiten:**
- Dynamische Set-Liste mit Buttons zum Entfernen
- Volumenanzeige wird während der Eingabe aktualisiert
- Automatische Set-Nummerierung
- Vollständige Validierung (keine leeren Sets, keine ungültigen Werte)

### 3. SetViewModel.cs
**Pfad:** `FitnessTracker/Views/ExerciseDialog.xaml.cs`

Ein einfaches ViewModel zur Unterstützung der UI-Bindung von Set-Daten:
- `SetNumber` - Satz-Nummer (1, 2, 3, etc.)
- `Reps` - Wiederholungen (nullable int)
- `Weight` - Gewicht in kg (nullable double)

### 4. Neue Converter
**Pfad:** `FitnessTracker/Converters.cs`

#### SetDetailsConverter
Konvertiert ein `Set` Objekt zu einem lesbaren String-Format:
- Eingabe: `Set` mit Reps=10, Weight=20
- Ausgabe: `"Satz: 10x 20.0kg"`

## Workflow: Übung während eines Workouts hinzufügen

1. **Workout auswählen** aus der Liste auf der linken Seite
2. **"+ Übung hinzufügen"** Button klicken
3. **Im ExerciseDialog:**
   - Aus dem Katalog eine Übung wählen ODER einen benutzerdefinierten Namen eingeben
   - Muskelgruppe auswählen
   - **Sets hinzufügen:**
     - Pro Set: Wiederholungen und Gewicht eingeben
     - "Set hinzufügen" für weitere Sets klicken
     - Gesamtvolumen wird live berechnet
   - "OK" klicken
4. **Übung im Workout angezeigt** mit:
   - Übungsname
   - Muskelgruppe
   - Anzahl der Sets
   - Gesamtvolumen dieser Übung
   - Edit/Delete Buttons
5. **Workout aktualisiert:** Der "Gesamtvolumen" Wert wird neu berechnet und angezeigt

## Volumeberechnung

Das **Gesamtvolumen** eines Workouts ist die Summe aller Übungen:

```
Workout-Volumen = Σ(Übung-Volumen)
Übung-Volumen = Σ(Set-Volumen)
Set-Volumen = Wiederholungen × Gewicht
```

**Beispiel:**
- Bankdrücken: 10x 60kg + 8x 65kg + 6x 70kg = 600 + 520 + 420 = **1540 kg**
- Kniebeuge: 12x 100kg + 10x 105kg = 1200 + 1050 = **2250 kg**
- **Workout-Volumen = 3790 kg**

## Integration mit bestehender Architektur

- **Models** (Workout, Exercise, Set) - Keine Änderungen, verwenden bestehende Struktur
- **Services** (WorkoutService) - Nutzt `UpdateWorkout()` um Änderungen zu speichern
- **Persistence** (DataService) - Automatisches Speichern von Übungen über JSON
- **UI (MainWindow)** - Neue Buttons und Anzeigen für Übungsverwaltung

## Features analog zu Liftoff

Die Implementierung folgt dem bewährten Muster von Fitness-Apps wie Liftoff:

✓ Vordefinierte Übungskatalog für schnelle Auswahl  
✓ Möglichkeit eigene Übungen zu definieren  
✓ Multi-Set Support pro Übung  
✓ Gewicht und Wiederholungen pro Set  
✓ Automatische Volumenberechnung  
✓ Edit/Delete Funktionalität  
✓ Live-Update der Gesamtwerte  

## Zukünftige Erweiterungen

- **1RM Tracking** - Verfolgung des aktuellen 1-Wiederholungs-Max
- **Performance-Graphen** - Visualisierung von Fortschritten über Zeit
- **Übung-Favoriten** - Markieren häufig verwendeter Übungen
- **Workout-Templates** - Speichern und Wiederverwenden von Workout-Routinen
- **Übungs-Notizen** - Zusätzliche Notizen pro Übung/Set
- **Auto-Gewichts-Vorschlag** - Basierend auf vorherigen Sets
