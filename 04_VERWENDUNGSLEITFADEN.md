# 📋 VERWENDUNGSLEITFADEN & ANWENDUNGSSZENARIEN

**Projekt:** Fitness Tracker WPF Applikation  
**Autor:** Entwicklungs-Team  
**Version:** 1.0  
**Datum:** 29.04.2026

---

## 🚀 Installation & Erste Schritte

### Systemanforderungen
- **Betriebssystem:** Windows 7 oder höher
- **Framework:** .NET Framework 4.8
- **RAM:** Minimal 256 MB
- **Festplatte:** ~50 MB freier Speicher

### Installation

#### Methode 1: Vorkompilierte EXE (Einfach)
```
1. Datei herunterladen:
   FitnessTracker\bin\Release\net48\FitnessTracker.exe

2. Doppelklick auf EXE
3. App startet sofort
```

#### Methode 2: Selbst kompilieren (Entwickler)
```powershell
# Terminal öffnen und zum Projekt-Verzeichnis navigieren
cd C:\Users\Philipp Imboden\source\repos\Workout-

# App bauen und starten
dotnet run --project FitnessTracker

# ODER nur bauen
dotnet build FitnessTracker
```

---

## 📖 Benutzer-Handbuch

### Überblick

Die Fitness Tracker App besteht aus zwei Hauptbereichen:

```
┌─────────────────────────────────────────────────┐
│           Fitness Tracker Fenster               │
├──────────────────┬──────────────────────────────┤
│                  │                              │
│  LINKES PANEL    │     RECHTES PANEL            │
│                  │                              │
│  • Suchfeld      │  Workout-Details             │
│  • Filter        │  • Infos                     │
│  • Neue Workout  │  • Übungen-Liste             │
│  • Workout-Liste │  • Aktions-Buttons           │
│                  │                              │
└──────────────────┴──────────────────────────────┘
```

### Schritt-für-Schritt Anleitungen

#### 1️⃣ Neues Workout erstellen

**Szenario:** Sie möchten Ihr heutiges Brusttraining registrieren.

```
Schritt 1: Klicke auf "+ Neues Workout" Button (grüner Button im Left Panel)
↓
Schritt 2: Ein Dialog öffnet sich
          - Name eingeben: "Brusttraining Montag"
          - Datum: Wird automatisch heute gesetzt (änderbar)
↓
Schritt 3: Klicke OK
↓
Ergebnis: Das neue Workout erscheint in der Liste links
```

**Dialog-Details:**
```
┌─────────────────────────────┐
│  Neues Workout              │
├─────────────────────────────┤
│ Name: [________________]     │
│ Datum: [22.04.2026] 📅      │
├─────────────────────────────┤
│       [OK]  [Abbrechen]     │
└─────────────────────────────┘
```

---

#### 2️⃣ Übung hinzufügen

**Szenario:** Sie haben gerade Bankdrücken gemacht (3 Sätze) und wollen es eintragen.

```
Schritt 1: Wähle das Workout in der Liste aus (left panel)
↓
Schritt 2: Klicke "+ Übung hinzufügen" Button
↓
Schritt 3: ExerciseDialog öffnet sich:

          a) Übungs-Auswahl:
             □ Aus Katalog wählen: "Bankdrücken" (Dropdown)
             ODER
             □ Benutzerdefinierten Namen eingeben

          b) Muskelgruppe:
             Wird automatisch gesetzt (z.B. "Brust")
             Kann geändert werden

          c) Sets hinzufügen:
             • Set 1: Reps = 10, Weight = 60
                     [Entfernen] Button
             • Set 2: Reps = 8, Weight = 65
                     [Entfernen] Button
             • Set 3: Reps = 6, Weight = 70
                     [Entfernen] Button

             Volumen wird live angezeigt:
             ✓ Gesamtvolumen: 1540 kg

             [+ Set hinzufügen] Button zum Hinzufügen

↓
Schritt 4: Klicke OK
↓
Ergebnis: Übung wird im Workout angezeigt mit:
          - Name: Bankdrücken
          - Muskelgruppe: Brust
          - Sets: 3
          - Volumen: 1540 kg
          - [✎ Bearbeiten] [✕ Löschen] Buttons
```

**ExerciseDialog Layout:**
```
┌─────────────────────────────────────┐
│  Übung hinzufügen                   │
├─────────────────────────────────────┤
│ Übung:       [▼ Bankdrücken    ]    │
│ oder Custom: [________________]     │
│                                     │
│ Muskelgruppe: [▼ Brust        ]     │
│                                     │
│ Sets:                               │
│ ┌─────────────────────────────────┐ │
│ │ Set 1: [__] × [__] kg [Entf]   │ │
│ │ Set 2: [__] × [__] kg [Entf]   │ │
│ │ Set 3: [__] × [__] kg [Entf]   │ │
│ │                                 │ │
│ │ [+ Set hinzufügen]              │ │
│ └─────────────────────────────────┘ │
│                                     │
│ Gesamtvolumen: 1540 kg              │
├─────────────────────────────────────┤
│        [OK]  [Abbrechen]            │
└─────────────────────────────────────┘
```

---

#### 3️⃣ Übung bearbeiten

**Szenario:** Sie haben einen Fehler bei den Wiederholungen gemacht (8 statt 10).

```
Schritt 1: Wähle das Workout aus
↓
Schritt 2: Im Right Panel findest du die Übungen-Liste
          Bei "Bankdrücken" findest du einen [✎] Button
↓
Schritt 3: Klicke [✎ Bearbeiten]
↓
Schritt 4: Der ExerciseDialog öffnet sich mit aktuellen Werten
          Set 2: Ändere 8 → 10
↓
Schritt 5: Klicke OK
↓
Ergebnis: Volumen wird neu berechnet
         Alte Volumen: 1540 kg
         Neue Volumen: 1550 kg ✓
```

---

#### 4️⃣ Übung löschen

**Szenario:** Sie möchten eine Übung aus dem Workout entfernen.

```
Schritt 1: Wähle das Workout aus
↓
Schritt 2: Im Right Panel: Übung findest [✕ Löschen] Button
↓
Schritt 3: Klicke [✕ Löschen]
↓
Schritt 4: Dialog zur Bestätigung:
          "Wirklich löschen?"
          [Ja] [Nein]
↓
Schritt 5: Klicke Ja
↓
Ergebnis: Übung wird gelöscht
         Gesamtvolumen wird neu berechnet
```

---

#### 5️⃣ Workout bearbeiten

**Szenario:** Sie möchten den Namen von "Brusttraining" zu "Intensives Brusttraining" ändern.

```
Schritt 1: Wähle das Workout aus (left panel)
↓
Schritt 2: Klicke [✎ Bearbeiten] Button (right panel)
↓
Schritt 3: Dialog öffnet:
          Name: [Brusttraining] (aktueller Name)
          Datum: [22.04.2026]
↓
Schritt 4: Ändere Name auf "Intensives Brusttraining"
↓
Schritt 5: Klicke OK
↓
Ergebnis: Workout-Name wird aktualisiert
         Alle Daten bleiben erhalten
```

---

#### 6️⃣ Workout als erledigt markieren

**Szenario:** Sie haben Ihr Training beendet und möchten es als erledigt markieren.

```
Schritt 1: Wähle das Workout aus
↓
Schritt 2: Klicke [✓ Erledigt] Button
↓
Ergebnis: Button ändert sich zu [↻ Zurück öffnen]
         Status-Icon ändert sich von ⊙ zu ✓
         Workout erscheint mit Häkchen in der Liste
```

---

#### 7️⃣ Nach Workout suchen

**Szenario:** Sie haben viele Workouts und suchen das "Brusttraining".

```
Schritt 1: Gib im Suchfeld "brust" ein
↓
Ergebnis: Die Liste wird live gefiltert
         Nur Workouts mit "brust" im Namen werden angezeigt

Tipp: Die Suche ist case-insensitive:
     "Brust" = "brust" = "BRUST" ✓
```

---

#### 8️⃣ Workouts nach Status filtern

**Szenario:** Sie möchten nur Ihre erledigten Workouts sehen.

```
Schritt 1: Im Left Panel findest du RadioButtons:
          ◯ Alle    (zeigt alle Workouts)
          ◯ Offen   (zeigt nur nicht erledigte)
          ◯ Erledigt (zeigt nur erledigte)
↓
Schritt 2: Wähle ◉ Erledigt
↓
Ergebnis: Liste wird gefiltert
         Nur erledigte Workouts angezeigt

Tipp: Suche + Filter kombinierbar:
     Suche "brust" + Filter "Erledigt"
     = nur erledigte Brusttrainings
```

---

### Vordefinierte Übungs-Katalog

Die App hat über 30 vordefinierte Übungen:

#### 💪 Brust
- Bankdrücken
- Schrägbankdrücken
- Hantelflüge
- Kabelflüge
- Liegestütze
- Dips

#### 🔙 Rücken
- Kreuzheben
- Latzug
- Rudermaschine
- Langhantelrudern
- Kurzhantelrudern
- Klimmzüge

#### 🤸 Schultern
- Schulterpresse
- Schulterdrücken
- Seitenheben
- Frontheben
- Reißen

#### 💪 Arme
- Langhantelcurls (Bizeps)
- Kurzhantelcurls (Bizeps)
- Kabelcurls (Bizeps)
- Trizepsdips
- Trizepsdrücken
- Kopfüberzug

#### 🦵 Beine
- Kniebeuge
- Beinpresse
- Beinstrecker
- Beincurl
- Beinheben
- Legpress

#### 🏋️ Core/Bauch
- Crunches
- Sit-ups
- Planks
- Beinheben hängend

---

## 💡 Tipps & Best Practices

### Volumen-Tracking richtig verstehen

**Formel:** Volumen = Wiederholungen × Gewicht

```
Beispiel Bankdrücken:
Set 1: 10 Wiederholungen × 60 kg = 600 kg
Set 2: 8 Wiederholungen × 65 kg = 520 kg
Set 3: 6 Wiederholungen × 70 kg = 420 kg
─────────────────────────────────────────
GESAMT: 1540 kg pro Übung
```

**Warum ist das wichtig?**
- ✓ Fortschritt messen (War das Volumen diese Woche höher?)
- ✓ Trainingsintensität vergleichen
- ✓ Übertraining vermeiden
- ✓ Muskelaufbau optimieren

### Best Practices

1. **Regelmäßig trainieren**
   - Tragen Sie Ihre Workouts sofort nach dem Training ein
   - So entsteht eine genaue Trainingshistorie

2. **Genaue Werte eingeben**
   - Zählen Sie Wiederholungen akkurat
   - Verwenden Sie die gleichen Gewichte (konsistent)

3. **Verwenden Sie den Katalog**
   - Eingabe ist schneller
   - Konsistente Benennungen
   - Muskelgruppe wird automatisch gesetzt

4. **Markieren Sie als erledigt**
   - Gibt psychologisches Feedback
   - Hilft bei der Motivationsverfolgung

5. **Nutzen Sie die Suche/Filter**
   - Finden Sie schnell ältere Workouts
   - Vergleichen Sie Fortschritt

---

## ❓ Häufig gestellte Fragen (FAQ)

### F: Wo werden meine Daten gespeichert?
**A:** Lokal im AppData-Verzeichnis:
```
C:\Users\[YourUsername]\AppData\Roaming\FitnessTracker\workouts.json
```
Sie können die Datei auch manuell bearbeiten (JSON-Format).

### F: Wird mein Training automatisch gespeichert?
**A:** Ja! Nach jeder Änderung (Add, Edit, Delete) wird automatisch gespeichert.

### F: Kann ich eigene Übungen hinzufügen?
**A:** Ja! Im ExerciseDialog im Custom-Textfeld einen Namen eingeben.

### F: Wie viele Sets pro Übung kann ich eintippen?
**A:** Unbegrenzt! Klicken Sie so oft "+ Set hinzufügen" wie nötig.

### F: Kann ich ein Workout wiederherstellen wenn ich es löscht?
**A:** Aktuell nicht (Feature für zukünftige Version). Seien Sie vorsichtig mit Delete!

### F: Funktioniert die App offline?
**A:** Ja! Die App benötigt kein Internet. Alles ist lokal.

### F: Kann ich die Übungen exportieren?
**A:** Noch nicht, aber geplant für v3.0

### F: Was passiert wenn ich die JSON-Datei loesche?
**A:** Die App erstellt eine neue leere beim nächsten Start.

---

## 🔗 Datenspeicherung

### Daten Struktur (JSON-Format)

```json
[
  {
    "Id": "abc123xyz...",
    "Name": "Brusttraining Montag",
    "Date": "2026-04-22T14:30:00",
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
      },
      {
        "Name": "Schrägbankdrücken",
        "Muscle": "Brust",
        "Sets": [
          {"Reps": 12, "Weight": 50.0},
          {"Reps": 10, "Weight": 55.0}
        ]
      }
    ]
  }
]
```

### Manuelles Bearbeiten
Sie können die JSON-Datei auch direkt bearbeiten:

1. Datei öffnen mit Text-Editor (Notepad++, VS Code, etc.)
2. JSON bearbeiten
3. Speichern
4. App neu starten

**ACHTUNG:** Ungültiges JSON kann zu Fehler führen!

---

## 🐛 Fehlerbehandlung

### Häufige Fehler & Lösungen

| Fehler | Ursache | Lösung |
|--------|--------|--------|
| "Datei nicht gefunden" | JSON korrupt | AppData-Ordner leeren & App neu starten |
| "Ungültige Eingabe" | Leeres Feld | Alle Felder ausfüllen |
| "App startet nicht" | .NET 4.8 fehlt | .NET 4.8 installieren |
| "Button funktioniert nicht" | Kein Workout gewählt | Erst Workout auswählen |

---

## 🔐 Datenschutz & Sicherheit

- ✅ **Keine Cloud-Speicherung** (alle Daten lokal)
- ✅ **Keine Telemetrie** (keine Datensammmlung)
- ✅ **Keine Abhängigkeiten** (nur .NET Framework)
- ✅ **Open Source** (Code ist einsehbar)

---

**Dokumentversion:** 1.0  
**Status:** ✅ FINAL  
**Last Updated:** 29.04.2026
