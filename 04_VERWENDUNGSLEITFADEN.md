# 📖 User Guide

## Quick Start

**Run the app:**
\\\powershell
cd Workout-
dotnet run --project FitnessTracker
\\\

**Or use EXE:**
\FitnessTracker\bin\Release\net48\FitnessTracker.exe\

## Usage

| Action | How |
|--------|-----|
| **Create Workout** | Click "New Workout" button → enter name & date |
| **Add Exercise** | Click "Add Exercise" → select from catalog |
| **Record Set** | Enter reps & weight → click "Add Set" |
| **Mark Done** | Check "Completed" checkbox |
| **Search** | Type in search box → auto-filters |
| **Filter** | Select "Done" or "Open" radio button |
| **Delete** | Right-click workout → "Delete" |

## UI Layout

`
┌─────────────────────────────────────┐
│  Fitness Tracker                    │
├──────────────┬──────────────────────┤
│  Workouts    │  Details             │
│  • Chest     │  Name: Chest Day     │
│  • Legs      │  Date: 2026-04-29    │
│  • Back      │  Exercises: 5        │
│              │  Volume: 12,500 kg   │
├──────────────┴──────────────────────┤
│  [New] [Edit] [Delete] [Refresh]    │
└─────────────────────────────────────┘
`

## Features

- ✅ Dark mode theme
- ✅ 30+ exercise catalog
- ✅ Multi-set support
- ✅ Volume calculation (Reps × Weight)
- ✅ Search & filter
- ✅ Auto-save to JSON
- ✅ Error handling
