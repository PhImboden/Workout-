# 📋 SPRINT PLANNING & REVIEWS

**Projekt:** Fitness Tracker WPF Applikation  
**Team:** Entwicklungs-Team  
**Gesamtdauer:** 5 Wochen (01.04 - 06.05.2026)

---

## 📅 Sprint 1: 01.04 - 08.04.2026

### 🎯 Sprint Ziele
- [ ] Basis-Architektur aufbauen
- [ ] CRUD-Operationen implementieren
- [ ] Benutzeroberfläche grundlegend erstellen
- [ ] Daten-Persistierung (JSON) einrichten

### 📋 Geplante Tasks

| Task ID | Task | Owner | Story # | Geschätzt | Status |
|---------|------|-------|---------|-----------|--------|
| S1-01 | Projekt-Setup (.csproj) | Dev | - | 0.5h | ✅ Done |
| S1-02 | Models (Workout, Exercise, Set) | Dev | 1,2,3 | 1.5h | ✅ Done |
| S1-03 | DataService (JSON I/O) | Dev | 5,6 | 2h | ✅ Done |
| S1-04 | WorkoutService (CRUD) | Dev | 1-4 | 2h | ✅ Done |
| S1-05 | MainWindow XAML (Layout) | Dev | 19 | 1.5h | ✅ Done |
| S1-06 | MainWindow Code-Behind | Dev | 1-4,18 | 2h | ✅ Done |
| S1-07 | WorkoutDialog (Create) | Dev | 1 | 1h | ✅ Done |
| S1-08 | Edit/Delete Funktionalität | Dev | 2,3 | 1.5h | ✅ Done |
| S1-09 | Fehlerbehandlung | Dev | 18 | 1h | ✅ Done |

**Total geplant: 13h | Tatsächlich: 12.5h**

### 📊 Sprint Review (08.04.2026)

**Was gut gelaufen ist:**
- ✅ Projekt-Struktur logisch und sauber
- ✅ Daten-Layer funktioniert zuverlässig
- ✅ UI ist responsiv und übersichtlich
- ✅ CRUD-Operationen alle funktional
- ✅ Alle Hoch-Priorität Stories fertig

**Probleme/Blocker:**
- ⚠️ Namespace-Fehler in XAML (behoben)
- ⚠️ Converter-Registrierung fehlte (behoben)

**Fertiggestellte Features:**
- ✅ Workout erstellen/bearbeiten/löschen
- ✅ Alle Workouts anzeigen
- ✅ Daten automatisch speichern/laden
- ✅ Fehlerbehandlung
- ✅ Basis-UI

**Burndown:** 13h geplant, 12.5h tatsächlich  
**Velocity:** 12.5 Story Points

---

## 📅 Sprint 2: 08.04 - 15.04.2026

### 🎯 Sprint Ziele
- [ ] Übungs-Katalog implementieren
- [ ] Multi-Set Support
- [ ] Volumenberechnung
- [ ] Übungs-Management (Add/Edit/Delete)

### 📋 Geplante Tasks

| Task ID | Task | Owner | Story # | Geschätzt | Status |
|---------|------|-------|---------|-----------|--------|
| S2-01 | ExerciseCatalog Service | Dev | 7 | 2h | ✅ Done |
| S2-02 | ExerciseDialog XAML | Dev | 7 | 1.5h | ✅ Done |
| S2-03 | ExerciseDialog Code-Behind | Dev | 7-11 | 2h | ✅ Done |
| S2-04 | SetViewModel | Dev | 9 | 0.5h | ✅ Done |
| S2-05 | Volumen-Berechnung | Dev | 21 | 1h | ✅ Done |
| S2-06 | SetDetailsConverter | Dev | 21,22 | 0.5h | ✅ Done |
| S2-07 | MainWindow Integration | Dev | 7,20 | 1.5h | ✅ Done |
| S2-08 | Edit/Delete Übungen | Dev | 8 | 1h | ✅ Done |
| S2-09 | Testing & Bugfix | Dev | All | 1h | ✅ Done |

**Total geplant: 11h | Tatsächlich: 10.5h**

### 📊 Sprint Review (15.04.2026)

**Was gut gelaufen ist:**
- ✅ Übungs-Katalog mit 30+ Übungen
- ✅ Multi-Set Input funktioniert perfekt
- ✅ Live-Volumenberechnung
- ✅ Integration in MainWindow smooth
- ✅ Alle Stories abgeschlossen

**Probleme/Blocker:**
- ⚠️ Validierung musste nachträglich erweitert werden (1h extra)

**Fertiggestellte Features:**
- ✅ Vordefinierter Übungs-Katalog (30+ Übungen)
- ✅ Übungsauswahl (Katalog oder Custom)
- ✅ Multi-Set Support (unbegrenzt)
- ✅ Wiederholungen & Gewicht pro Set
- ✅ Live-Volumenberechnung
- ✅ Edit/Delete Übungen
- ✅ Muskelgruppen-Anzeige

**Burndown:** 11h geplant, 10.5h tatsächlich  
**Velocity:** 11 Story Points

---

## 📅 Sprint 3: 15.04 - 22.04.2026

### 🎯 Sprint Ziele
- [ ] Suche implementieren
- [ ] Filter (Alle/Offen/Erledigt)
- [ ] Status-Markierung
- [ ] Vergangene Workouts anzeigen

### 📋 Geplante Tasks

| Task ID | Task | Owner | Story # | Geschätzt | Status |
|---------|------|-------|---------|-----------|--------|
| S3-01 | Suche-Funktionalität | Dev | 16 | 1h | ✅ Done |
| S3-02 | Filter-Logik | Dev | 17 | 1h | ✅ Done |
| S3-03 | UI für Suche/Filter | Dev | 16,17 | 0.5h | ✅ Done |
| S3-04 | Status-Toggle (Erledigt) | Dev | 14 | 1h | ✅ Done |
| S3-05 | Status-Anzeige (Häkchen) | Dev | 15 | 0.5h | ✅ Done |
| S3-06 | Datum-Handling | Dev | 13 | 0.5h | ✅ Done |
| S3-07 | Testing | Dev | All | 1.5h | ✅ Done |

**Total geplant: 6h | Tatsächlich: 5.5h**

### 📊 Sprint Review (22.04.2026)

**Was gut gelaufen ist:**
- ✅ Suche sehr responsiv
- ✅ Filter funktionieren perfekt
- ✅ Status-Markierung klar sichtbar
- ✅ Alle Stories fertig
- ✅ Keine Bugs entdeckt

**Probleme/Blocker:**
- Keine

**Fertiggestellte Features:**
- ✅ Suche nach Workout-Namen
- ✅ Filter: Alle/Offen/Erledigt
- ✅ Live-Filter während Eingabe
- ✅ Workout als erledigt markieren
- ✅ Status-Icon (✓ oder ⊙)
- ✅ Vergangene Workouts anzeigen

**Burndown:** 6h geplant, 5.5h tatsächlich  
**Velocity:** 6 Story Points

---

## 📅 Sprint 4: 22.04 - 29.04.2026

### 🎯 Sprint Ziele
- [ ] UI-Modernisierung (Dark Mode)
- [ ] Performance-Optimierung
- [ ] Code-Cleanup
- [ ] Dokumentation erweitern

### 📋 Geplante Tasks

| Task ID | Task | Owner | Story # | Geschätzt | Status |
|---------|------|-------|---------|-----------|--------|
| S4-01 | Dark Mode Theme | Design | - | 2h | ✅ Done |
| S4-02 | Button-Styling | Design | 20 | 1h | ✅ Done |
| S4-03 | Input-Felder Styling | Design | - | 0.5h | ✅ Done |
| S4-04 | Color-Scheme anpassen | Design | - | 1h | ✅ Done |
| S4-05 | Performance-Optimierung | Dev | - | 1h | ✅ Done |
| S4-06 | Code-Cleanup | Dev | - | 1.5h | ✅ Done |
| S4-07 | Dokumentation (README, etc) | Dev | - | 2h | ✅ Done |
| S4-08 | Build-Optimierung | Dev | - | 0.5h | ✅ Done |

**Total geplant: 9.5h | Tatsächlich: 9h**

### 📊 Sprint Review (29.04.2026)

**Was gut gelaufen ist:**
- ✅ Dark Mode sieht professionell aus
- ✅ Performance deutlich besser
- ✅ Code ist sauberer
- ✅ Dokumentation komplett
- ✅ Build-Prozess optimiert

**Probleme/Blocker:**
- ⚠️ Farb-Kontraste mussten teilweise angepasst werden

**Fertiggestellte Features:**
- ✅ Dark Mode Theme
- ✅ Moderne Button-Styles
- ✅ Input-Feld Improvements
- ✅ Konsistente Color-Palette
- ✅ Performance-Optimierungen
- ✅ Build-Zeit: 1.1s

**Burndown:** 9.5h geplant, 9h tatsächlich  
**Velocity:** 9 Story Points

---

## 📅 Sprint 5: 29.04 - 06.05.2026

### 🎯 Sprint Ziele
- [ ] Finale Tests durchführen
- [ ] Fehler-Fixes
- [ ] Dokumentation finalisieren
- [ ] Release vorbereiten

### 📋 Geplante Tasks

| Task ID | Task | Owner | Story # | Geschätzt | Status |
|---------|------|-------|---------|-----------|--------|
| S5-01 | Manuelle Tests durchführen | QA | All | 3h | ✅ Done |
| S5-02 | Bug-Fixes | Dev | - | 1.5h | ✅ Done |
| S5-03 | Edge-Cases testen | QA | - | 1.5h | ✅ Done |
| S5-04 | Dokumentation finalisieren | Dev | - | 1h | ✅ Done |
| S5-05 | Release-Build erstellen | Dev | - | 0.5h | ✅ Done |
| S5-06 | Final Checklist | QA | - | 1h | ✅ Done |

**Total geplant: 8.5h | Tatsächlich: 8h**

### 📊 Sprint Review (06.05.2026)

**Was gut gelaufen ist:**
- ✅ Alle Tests bestanden
- ✅ Keine kritischen Bugs
- ✅ Dokumentation vollständig
- ✅ Release-Ready
- ✅ User-Zufriedenheit hoch

**Probleme/Blocker:**
- Keine

**Fertiggestellte Features:**
- ✅ Alle User Stories implementiert
- ✅ Alle Tests bestanden
- ✅ Dokumentation komplett
- ✅ Release-Build erstellt
- ✅ Final Checklist bestanden

**Burndown:** 8.5h geplant, 8h tatsächlich  
**Velocity:** 8 Story Points

---

## 📊 Projekt-Übersicht

### Gesamtstatistiken

| Metrik | Wert |
|--------|------|
| **Gesamte Sprints** | 5 |
| **Gesamte Stunden geplant** | 47.5h |
| **Gesamte Stunden tatsächlich** | 45.5h |
| **Effizienz** | 95.8% |
| **Gesamte Story Points** | 46 |
| **Durchschn. Velocity** | 9.2 SP/Sprint |

### Implementierte Features

| Priorität | Geplant | Fertig | % |
|-----------|---------|--------|-----|
| Hoch | 14 | 14 | 100% ✅ |
| Mittel | 8 | 8 | 100% ✅ |
| Niedrig | 2 | 0 | 0% (Future) |
| **Gesamt** | **24** | **22** | **91.7%** |

### Burndown-Chart (Vereinfacht)
```
Sprint 1: ████████ 12.5h (geplant: 13h)
Sprint 2: ██████   10.5h (geplant: 11h)
Sprint 3: ████     5.5h  (geplant: 6h)
Sprint 4: ████████ 9h    (geplant: 9.5h)
Sprint 5: ████████ 8h    (geplant: 8.5h)
─────────────────────────────────────
Total:   45.5h (geplant: 47.5h) ✅
```

---

**Dokumentversion:** 1.0  
**Letzte Aktualisierung:** 06.05.2026  
**Status:** ✅ PROJEKT ABGESCHLOSSEN
