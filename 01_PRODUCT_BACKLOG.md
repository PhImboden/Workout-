# 📋 PRODUCT BACKLOG - Fitness Tracker

**Projekt:** Fitness Tracker WPF Applikation  
**Technologie:** C# WPF (.NET Framework)  
**Speicherung:** JSON-Dateien  
**Deadline:** 06.05.2026

---

## 📝 Projektbeschreibung

Die Applikation ermöglicht es Benutzern, Workouts zu erstellen, zu verwalten und Fortschritte zu verfolgen. Alle Daten werden lokal in JSON-Dateien gespeichert. Die Anwendung bietet ein benutzerfreundliches Interface zum Erfassen von Trainingseinheiten mit verschiedenen Übungen, Sätzen und Gewichten.

---

## 📊 Product Backlog - User Stories

| ID | User Story | Priorität | Status | Sprint | Notizen |
|----|-----------|-----------|---------|---------|---------| 
| 1 | Workout erstellen | Hoch | ✅ Done | Sprint 1 | Name + Datum |
| 2 | Workout löschen | Hoch | ✅ Done | Sprint 1 | Mit Bestätigung |
| 3 | Workout bearbeiten | Hoch | ✅ Done | Sprint 1 | Name/Datum ändern |
| 4 | Alle Workouts anzeigen | Hoch | ✅ Done | Sprint 1 | Liste view |
| 5 | Daten beim Start laden | Hoch | ✅ Done | Sprint 1 | Aus JSON |
| 6 | Daten automatisch speichern | Hoch | ✅ Done | Sprint 1 | Nach jeder Änderung |
| 7 | Übungen hinzufügen | Hoch | ✅ Done | Sprint 2 | Mit Katalog |
| 8 | Übungen entfernen | Hoch | ✅ Done | Sprint 2 | Mit Delete-Button |
| 9 | Sätze erfassen | Hoch | ✅ Done | Sprint 2 | Multi-Set Support |
| 10 | Wiederholungen erfassen | Hoch | ✅ Done | Sprint 2 | Pro Set |
| 11 | Gewicht eingeben | Mittel | ✅ Done | Sprint 2 | Pro Set in kg |
| 12 | Datum setzen | Mittel | ✅ Done | Sprint 1 | DateTime Picker |
| 13 | Vergangene Workouts ansehen | Mittel | ✅ Done | Sprint 3 | Historische Daten |
| 14 | Workout als erledigt markieren | Hoch | ✅ Done | Sprint 3 | Status-Toggle |
| 15 | Erledigte Workouts erkennen | Mittel | ✅ Done | Sprint 3 | Häkchen-Symbol |
| 16 | Suche nach Workouts | Mittel | ✅ Done | Sprint 3 | Live-Filter |
| 17 | Filter (erledigt/offen) | Mittel | ✅ Done | Sprint 3 | RadioButtons |
| 18 | Fehlermeldungen anzeigen | Hoch | ✅ Done | Sprint 1 | Error Handling |
| 19 | Einfache Benutzeroberfläche | Hoch | ✅ Done | Sprint 1 | 2-spalten Layout |
| 20 | Buttons für Aktionen | Hoch | ✅ Done | Sprint 1-5 | Edit, Delete, Add |
| 21 | Volumen nach Workout anzeigen | Mittel | ✅ Done | Sprint 2 | Reps × Weight |
| 22 | Nach Workout anzeigen wo (BP) gemacht | Mittel | ✅ Done | Sprint 2 | Muskelgruppe |
| 23 | Meldung bei keinen Daten | Niedrig | ⏳ Future | Backlog | Optional |
| 24 | Doppelte Workouts vermeiden | Mittel | ⏳ Future | Backlog | Validierung |

---

## 🎯 Akzeptanzkriterien

### Workout erstellen (User Story #1)
- [ ] Name darf nicht leer sein
- [ ] Wird nach Eingabe in der Liste angezeigt
- [ ] Wird sofort in JSON gespeichert
- [ ] Datum wird automatisch gesetzt (falls nicht angegeben)

### Volumen-Berechnung (User Story #21)
- [ ] Formel: Volume = Reps × Weight
- [ ] Wird nach Eingabe automatisch berechnet
- [ ] Gesamtvolumen pro Workout angezeigt
- [ ] Live-Update während Dateneingabe

### Daten-Persistierung (User Story #6)
- [ ] Änderungen speichern sich automatisch
- [ ] JSON-Format ist gültig
- [ ] Fehler werden gehandhabt
- [ ] AppData-Verzeichnis wird erstellt

### Benutzeroberfläche (User Story #19)
- [ ] 2-spalten Layout (Liste + Details)
- [ ] Alle Buttons funktionieren
- [ ] Responsive Design
- [ ] Icons/Symbole sind sichtbar

---

## 📈 Regeln & Anforderungen

### Technische Anforderungen
- ✅ Speicherung in JSON-Dateien (local)
- ✅ Beim Start Daten laden
- ✅ Änderungen sofort speichern
- ✅ Keine Datenbank-Abhängigkeit
- ✅ WPF-Oberfläche
- ✅ .NET Framework 4.8

### Qualitäts-Anforderungen
- ✅ Keine Compile-Fehler
- ✅ Keine Runtime-Fehler
- ✅ Error Handling
- ✅ SOLID-Prinzipien
- ✅ Code-Dokumentation

### UX-Anforderungen
- ✅ Intuitive Bedienung
- ✅ Klare Fehlermeldungen
- ✅ Responsive Layout
- ✅ Sichtbare Feedback

---

## 📅 Sprint Übersicht

| Sprint | Zeitraum | Focus | Status |
|--------|----------|-------|--------|
| Sprint 1 | 01.04 - 08.04 | Basis CRUD, UI Setup | ✅ Done |
| Sprint 2 | 08.04 - 15.04 | Übungs-Katalog, Sets | ✅ Done |
| Sprint 3 | 15.04 - 22.04 | Suche/Filter, Refine | ✅ Done |
| Sprint 4 | 22.04 - 29.04 | Optimierung, UI-Update | ✅ Done |
| Sprint 5 | 29.04 - 06.05 | Finalizing, Testing | ✅ Done |

---

## 🔄 Änderungshistorie

| Datum | Änderung | Autor | Status |
|-------|----------|-------|--------|
| 01.04.2026 | Initiales Backlog erstellt | Team | ✅ |
| 08.04.2026 | Übungs-Katalog hinzugefügt | Team | ✅ |
| 15.04.2026 | Suche/Filter erweitert | Team | ✅ |
| 22.04.2026 | UI-Modernisierung | Team | ✅ |
| 29.04.2026 | Finale Optimierungen | Team | ✅ |

---

**Dokumentversion:** 2.0  
**Letzte Aktualisierung:** 29.04.2026  
**Status:** ✅ ABGESCHLOSSEN
