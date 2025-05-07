Berikut adalah contoh struktur project backend .NET Web API dengan pola CQRS + MediatR, menggunakan Entity Framework Core dan struktur yang rapi untuk scalability.

MyApp.CQRS/
├── MyApp.API/                  <-- Proyek Web API (presentation)
│   ├── Controllers/
│   ├── Program.cs
│   └── appsettings.json
│
├── MyApp.Application/          <-- Layer aplikasi (CQRS + Use Cases)
│   ├── Commands/
│   │   └── CreateTask/
│   │       ├── CreateTaskCommand.cs
│   │       └── CreateTaskCommandHandler.cs
│   ├── Queries/
│   │   └── GetTasks/
│   │       ├── GetTasksQuery.cs
│   │       └── GetTasksQueryHandler.cs
│   ├── Interfaces/
│   │   └── ITaskRepository.cs
│   └── Models/
│       └── TaskDto.cs
│
├── MyApp.Domain/               <-- Inti domain bisnis
│   └── Entities/
│       └── TaskItem.cs
│
├── MyApp.Infrastructure/      <-- Implementasi DB, repo, dan eksternal
│   ├── Data/
│   │   ├── AppDbContext.cs
│   └── Repositories/
│       └── TaskRepository.cs
│
└── MyApp.Tests/                <-- Unit & integration tests
