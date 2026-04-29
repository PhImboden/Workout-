# Fitness Tracker - Anwendungsbeispiel mit Übungskatalog

## Szenario: Ein komplett Workout durchführen

### Schritt 1: Neues Workout erstellen
1. App starten
2. **"+ Neues Workout"** Button klicken
3. Dialog mit:
   - Name: `"Brusttraining Montag"`
   - Datum: `22.04.2026`
4. **OK** klicken

### Schritt 2: Erste Übung hinzufügen - Bankdrücken
1. Das neue Workout ist jetzt ausgewählt
2. **"+ Übung hinzufügen"** Button klicken
3. Im ExerciseDialog:
   - **Übungs-Combo:** Wähle `"Bankdrücken"` 
   - **Muskelgruppe:** Wird automatisch auf `"Brust"` gesetzt
   - **Sets hinzufügen:**
     - Set 1: 10 Wiederholungen, 60kg
     - Set 2: 8 Wiederholungen, 65kg
     - Set 3: 6 Wiederholungen, 70kg
   - Die App zeigt: **"Gesamt-Volumen: 1540 kg"**
4. **OK** klicken

**Ergebnis in Workout-Details:**
```
Übungen:
├─ Bankdrücken (Brust)
│  ├─ Sätze: 3
│  ├─ Volumen: 1540.0 kg
│  ├─ Satz: 10x 60.0kg
│  ├─ Satz: 8x 65.0kg
│  ├─ Satz: 6x 70.0kg
│  └─ [✎ Bearbeiten] [✕ Löschen]
```

### Schritt 3: Zweite Übung - Schrägbankdrücken
1. **"+ Übung hinzufügen"** erneut klicken
2. **Übungs-Combo:** Wähle `"Schrägbankdrücken"`
3. **Sets:**
   - Set 1: 12 Wiederholungen, 50kg
   - Set 2: 10 Wiederholungen, 55kg
4. Volumen: **"Gesamt-Volumen: 1150 kg"**
5. **OK**

### Schritt 4: Dritte Übung - Hantelflüge
1. **"+ Übung hinzufügen"**
2. **Übungs-Combo:** `"Hantelflüge"`
3. **Sets:**
   - Set 1: 12 Wiederholungen, 30kg
   - Set 2: 12 Wiederholungen, 30kg
4. Volumen: **"Gesamt-Volumen: 720 kg"**
5. **OK**

### Schritt 5: Benutzerdefinierte Übung
1. **"+ Übung hinzufügen"**
2. **Übungs-Combo:** Nicht auswählen
3. **Custom Übung:** `"Kabelflüge mit 1 Sekunde Halten"` eingeben
4. **Muskelgruppe:** Wähle `"Brust"`
5. **Sets:**
   - Set 1: 15 Wiederholungen, 25kg
6. Volumen: **"Gesamt-Volumen: 375 kg"**
7. **OK**

### Ergebnis: Vollständiges Workout

**MainWindow Anzeige:**
```
Workout-Titel: Brusttraining Montag
Datum: 22.04.2026 10:30
Status: ⊙ Offen
Gesamtvolumen: 3785.0 kg  ← AUTOMATISCH BERECHNET!

Übungen:
├─ Bankdrücken (Brust)
│  Sätze: 3, Volumen: 1540.0 kg
│  [✎] [✕]
├─ Schrägbankdrücken (Brust)
│  Sätze: 2, Volumen: 1150.0 kg
│  [✎] [✕]
├─ Hantelflüge (Brust)
│  Sätze: 2, Volumen: 720.0 kg
│  [✎] [✕]
└─ Kabelflüge mit 1 Sekunde Halten (Brust)
   Sätze: 1, Volumen: 375.0 kg
   [✎] [✕]

[+ Übung hinzufügen]
[✎ Bearbeiten] [✓ Erledigt] [🗑 Löschen]
```

### Schritt 6: Bearbeiten einer Übung
1. Bei Bankdrücken: **"✎ Bearbeiten"** klicken
2. Dialog öffnet sich mit aktuellen Daten:
   - Bankdrücken, Brust, 3 Sets
3. Change: Set 2 von 8x65kg auf 9x65kg ändern
4. Volumen ändert sich zu: **"1549 kg"**
5. **OK**

### Schritt 7: Workout als erledigt markieren
1. **"✓ Erledigt"** Button klicken
2. Status ändert sich zu: **"✓ Erledigt"**
3. Button-Text ändert sich zu: **"↻ Zurück öffnen"**

### Schritt 8: Übersicht in der Workout-Liste
```
[Suche] [Alle] [Offen] [Erledigt]

Workouts:
├─ Brusttraining Montag ✓
│  22.04.2026
│  Übungen: 4
├─ Rückentraining Dienstag
│  21.04.2026
│  Übungen: 3
└─ Beintraining Freitag
   20.04.2026
   Übungen: 5
```

## Katalog-Übersicht

Die App hat diese vorgefertigten Übungen:

### 💪 Brust
- Bankdrücken
- Schrägbankdrücken
- Hantelflüge
- Kabelflüge
- Liegestütze
- Dips

### 🔙 Rücken
- Kreuzheben
- Latzug
- Rudermaschine
- Langhantelrudern
- Kurzhantelrudern
- Klimmzüge

### 🤸 Schultern
- Schulterpresse
- Schulterdrücken
- Seitenheben
- Frontheben
- Reißen

### 💪 Arme
- Langhantelcurls (Bizeps)
- Kurzhantelcurls (Bizeps)
- Kabelcurls (Bizeps)
- Trizepsdips
- Trizepsdrücken
- Kopfüberzug

### 🦵 Beine
- Kniebeuge
- Beinpresse
- Beinstrecker
- Beincurl
- Beinheben
- Legpress

### 🏋️ Core/Bauch
- Crunches
- Sit-ups
- Planks
- Beinheben hängend

## Volumen-Berechnung Verständnis

Das **Volumen** ist eine wichtige Metrik im Krafttraining, um den Trainingsumfang zu messen.

**Berechnung:**
```
Volume = Reps × Weight
```

**Beispiel: Ein Set mit 10 Wiederholungen à 60kg:**
- Volume = 10 × 60 = **600 kg**

**Ein komplettes Workout:**
```
Bankdrücken Set 1: 10 × 60 = 600
Bankdrücken Set 2: 8 × 65 = 520
Bankdrücken Set 3: 6 × 70 = 420
Kniebeuge Set 1: 12 × 100 = 1200
Kniebeuge Set 2: 10 × 105 = 1050
─────────────────────────────
Gesamt-Volumen = 3790 kg
```

Dieses Volumen hilft dir:
- **Fortschritt messen** - Ist das Volumen über die Woche gestiegen?
- **Trainingsintensität vergleichen** - War dieses Workout schwerer als das letzte?
- **Übertraining vermeiden** - Zu hohes Volumen kann zu Übertraining führen
- **Muskelaufbau optimieren** - Das optimale Volumen pro Muskelgruppe ist etwa 10-20 Sets pro Woche

## Tipps zur Nutzung

✅ **Immer den richtigen Namen aus dem Katalog wählen** - Für konsistente Daten  
✅ **Benutzerdefinierte Übungen nutzen** - Für spezielle Variationen  
✅ **Mehrere Sets pro Übung** - Für realistische Trainingsabläufe  
✅ **Genaue Wiederholungen und Gewichte tracken** - Für objektiven Fortschritt  
✅ **Regelmäßig trainieren** - Zum Aufbau von Trainingsdaten  
✅ **Workouts als erledigt markieren** - Für Übersicht und Motivation

## FAQ

**F: Kann ich die Übungen selbst hinzufügen?**  
A: Ja! Du kannst beliebige Übungen eingeben, indem du den Namen im Text-Feld eingibst statt einen aus dem Katalog auszuwählen.

**F: Wie viele Sets kann ich pro Übung hinzufügen?**  
A: Unbegrenzt! Klicke so oft auf "+ Set hinzufügen" wie nötig.

**F: Wird das Volumen automatisch berechnet?**  
A: Ja! Die App berechnet das Volumen automatisch und aktualisiert es in Echtzeit, während du Sets eingibst.

**F: Kann ich eine Übung später bearbeiten?**  
A: Ja! Klicke auf den "✎ Bearbeiten" Button bei der Übung, um Sets zu ändern.

**F: Wird alles automatisch gespeichert?**  
A: Ja! Alle Änderungen werden sofort in die lokale JSON-Datei gespeichert.
