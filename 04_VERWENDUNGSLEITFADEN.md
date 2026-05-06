# 📖 Benutzer-Handbuch

## Installation

\\\powershell
# Option 1: EXE starten
FitnessTracker\bin\Release\net48\FitnessTracker.exe

# Option 2: Neu bauen
cd FitnessTracker
dotnet build
dotnet run --project FitnessTracker
\\\

## Quick Start

### 1. Neues Workout erstellen
1. Klick: \"+  Neues Workout\" Button
2. Name eingeben (z.B. \"Brusttraining\")
3. Datum (optional)
4. OK

### 2. Übung hinzufügen
1. Workout auswählen (Links)
2. Klick: \"+  Übung hinzufügen\"
3. Im Dialog:
   - Übung aus Katalog OR custom Name
   - Sets mit Reps × Weight (z.B. 10 × 60kg)
   - \"+ Set hinzufügen\" für mehrere Sets
   - OK
4. Volumen berechnet sich automatisch

### 3. Workout bearbeiten
- **Edit:** Workout auswählen → \"Bearbeiten\"
- **Delete:** Workout → \"Löschen\" (mit Bestätigung)
- **Mark Done:** \"✓ Erledigt\" 

### 4. Suchen & Filtern
- **Suche:** Suchfeld (Live-Filter)
- **Filter:** RadioButtons (Alle/Offen/Erledigt)

## Übungs-Katalog (Auszug)

**Brust:** Bankdrücken, Schrägbankdrücken, Hantelflüge  
**Rücken:** Kreuzheben, Latzug, Klimmzüge  
**Schultern:** Schulterpresse, Seitenheben  
**Arme:** Bizeps-Curls, Trizeps-Dips  
**Beine:** Kniebeuge, Beinpresse, Beincurl  
**Core:** Crunches, Planks  

## Datenspeicherung

Daten werden gespeichert in:
\C:\Users\[User]\AppData\Roaming\FitnessTracker\workouts.json\

Datei ist lesbar & editierbar (JSON-Format).

## FAQ

**F: Wo sind meine Daten?**  
A: %APPDATA%\FitnessTracker\workouts.json

**F: Wird automatisch gespeichert?**  
A: Ja, nach jeder Änderung

**F: Unbegrenzte Sets?**  
A: Ja! Klick \"+  Set hinzufügen\" so oft wie nötig

**F: Kann ich eigene Übungen hinzufügen?**  
A: Ja, im Dialog im Custom-Textfeld

**F: Funktioniert offline?**  
A: Ja, alles lokal
