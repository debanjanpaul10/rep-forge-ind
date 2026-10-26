# 💪 RepForge

> Forge Discipline. Track Every Rep. Measure Every Gain.

RepForge is a cloud-native fitness tracking platform built with **Angular**, **ASP.NET Core**, **MongoDB**, and **Azure**. It is designed to help athletes and fitness enthusiasts manage workout splits, log exercises, track weights and repetitions, and monitor long-term strength progression.

The primary goal of RepForge is to provide a simple, distraction-free workout journal focused on consistency, progressive overload, and measurable results.

---

## 🚀 Vision

Most fitness applications are cluttered with social features, advertisements, subscriptions, and unnecessary complexity.

RepForge aims to be different:

- Track workouts efficiently
- Focus on strength progression
- Maintain complete workout history
- Visualize performance over time
- Own your data

Built by a developer, for lifters.

---

## ✨ Features

### Workout Split Management

Create and manage training splits such as:

- Push / Pull / Legs
- Bro Split
- Upper / Lower
- Custom Training Programs

Example:

```text
Monday      Chest & Triceps
Tuesday     Back & Biceps
Wednesday   Legs
Thursday    Shoulders
Friday      Arms
Saturday    Cardio
Sunday      Rest
```

### Exercise Library

Maintain a catalog of exercises:

- Bench Press
- Deadlift
- Squat
- Pull-Up
- Overhead Press

Organized by muscle groups for easy management.

### Workout Logging

Track every set performed:

```text
Bench Press

Set 1: 80kg × 10
Set 2: 85kg × 8
Set 3: 90kg × 6
```

### Progressive Overload Tracking

Monitor improvements over time:

- Weight progression
- Repetition progression
- Training consistency
- Personal records

### Workout History

Access your complete training history and compare past performances.

### Analytics & Insights (Future)

- Volume tracking
- Strength trends
- Weekly summaries
- Personal records
- Training consistency metrics

---

## 🏗️ Technology Stack

### Frontend

- Angular
- Angular Material
- RxJS
- TypeScript

### Backend

- ASP.NET Core Web API
- Clean Architecture
- Dependency Injection
- OpenAPI / Swagger

### Database

- MongoDB Atlas

### Cloud

- Azure App Service
- Azure Functions
- Azure Storage
- Azure Monitor

---

## 📂 Solution Structure

```text
RepForge.Ind.Backend

├── API
│   └── RepForge.Ind.Api
│
├── Core
│   ├── RepForge.Ind.Domain
│   ├── RepForge.Ind.Application
│   └── RepForge.Ind.Contracts
│
├── Database
│   └── RepForge.Ind.Infrastructure.Mongo
│
└── Functions
    └── RepForge.Ind.Functions
```

### Architecture Layers

#### Domain

Contains core business entities and rules.

```text
Exercise
WorkoutSplit
WorkoutSession
ExerciseSet
```

#### Application

Contains use cases, services, validations, and repository contracts.

#### Infrastructure

Contains MongoDB integrations, repository implementations, and external dependencies.

#### API

Responsible for exposing REST endpoints.

#### Functions

Responsible for background processing, scheduled jobs, notifications, and analytics generation.

---

## 🧱 Architectural Principles

RepForge follows the principles of:

- Clean Architecture
- Domain-Driven Design (Lightweight)
- SOLID Principles
- Separation of Concerns
- Dependency Inversion

Dependencies always point inward:

```text
API
 ↓

Application
 ↓

Domain

Infrastructure
 ↑
Application
```

The domain remains independent of frameworks, databases, and external technologies.

---

## 🎯 Initial Release Scope (MVP)

### Included

- Exercise management
- Workout split management
- Workout session logging
- Weight and repetition tracking
- Workout history
- Azure deployment

### Future Enhancements

- Authentication
- Personal records
- Body weight tracking
- Progress photos
- Nutrition tracking
- Workout templates
- CSV export
- PDF export
- Mobile experience
- Push notifications
- AI-powered workout insights

---

## 🔥 Example Workflow

```text
1. Create Exercises
   ↓
2. Create Workout Splits
   ↓
3. Start Workout Session
   ↓
4. Log Sets
   ↓
5. Track Progress
   ↓
6. Beat Previous Records
```

---

## 📈 Project Status

Current Phase:

```text
✅ Repository Setup
✅ Solution Structure
🚧 Domain Design
⬜ Application Layer
⬜ MongoDB Infrastructure
⬜ REST API
⬜ Angular UI
⬜ Azure Deployment
```

---

## 🤝 Contributing

This project is currently being developed as a personal fitness platform and learning journey around Angular, ASP.NET Core, MongoDB, Azure, and Clean Architecture.

---

## 📜 License

MIT License

---

### "The strongest results come from the reps nobody else sees."
