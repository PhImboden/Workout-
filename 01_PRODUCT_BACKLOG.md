# 📋 Product Backlog

**Fitness Tracker WPF** | C# + JSON | Deadline: 06.05.2026

## User Stories (24 Total)

| # | Story | Priorität | Status |
|---|-------|-----------|--------|
| 1 | Workout erstellen | High | ✅ |
| 2 | Workout löschen | High | ✅ |
| 3 | Workout bearbeiten | High | ✅ |
| 4 | Alle Workouts anzeigen | High | ✅ |
| 5 | Daten beim Start laden | High | ✅ |
| 6 | Daten automatisch speichern | High | ✅ |
| 7 | Übungen hinzufügen | High | ✅ |
| 8 | Übungen entfernen | High | ✅ |
| 9 | Sätze erfassen | High | ✅ |
| 10 | Wiederholungen erfassen | High | ✅ |
| 11 | Gewicht eingeben | Medium | ✅ |
| 12 | Datum setzen | Medium | ✅ |
| 13 | Vergangene Workouts ansehen | Medium | ✅ |
| 14 | Workout als erledigt markieren | High | ✅ |
| 15 | Erledigte Workouts erkennen | Medium | ✅ |
| 16 | Suche nach Workouts | Medium | ✅ |
| 17 | Filter (erledigt/offen) | Medium | ✅ |
| 18 | Fehlermeldungen anzeigen | High | ✅ |
| 19 | Einfache Benutzeroberfläche | High | ✅ |
| 20 | Buttons für Aktionen | High | ✅ |
| 21 | Volumen nach Workout | Medium | ✅ |
| 22 | Muskelgruppe-Anzeige | Medium | ✅ |
| 23 | Meldung bei keinen Daten | Low | ⏳ |
| 24 | Doppelte Workouts vermeiden | Low | ⏳ |

## Akzeptanzkriterien

**Workout erstellen:**
- Name nicht leer
- In Liste angezeigt
- In JSON gespeichert
- Datum automatisch gesetzt

**Volumen-Berechnung:**
- Formel: Reps × Weight
- Live-Berechnung
- Pro Übung & Workout

**Persistierung:**
- Auto-Save nach Änderung
- Gültiges JSON-Format
- Error-Handling
- AppData-Verzeichnis

**UI:**
- 2-spalten Layout
- Responsive Design
- Alle Buttons funktional
- Icons sichtbar

## Sprint-Zuordnung

| Sprint | Features |
|--------|----------|
| 1 | CRUD-Operationen, Basis-UI |
| 2 | Übungs-Katalog, Multi-Set, Volumen |
| 3 | Suche, Filter, Status |
| 4 | Dark Mode, Optimierung |
| 5 | Testing, Finalization |

**Status:** 22/24 implementiert (91.7%) ✅
