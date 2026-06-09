This is the roadmap for learning C#. Every phase has its own readme containing more information per project to build in the phase.

This roadmap was created with help of AI.

## Phase 1: Learn C# Properly

### Topics:

- Variables and types
- Methods
- Classes and objects
- Interfaces
- Inheritance
- Generics
- Collections (List<T>, Dictionary<TKey,TValue>)
- Exception handling
- LINQ
- Async/await
- Delegates and events

### Build:

- Console calculator
- Todo list application
- File organizer
- Simple inventory manager
- Weather API client

The goal is to become comfortable reading and writing C# without thinking about syntax.

## Phase 2: Learn .NET Fundamentals

### Topics:

- Project structure
- NuGet packages
- Dependency Injection
- Configuration
- Logging
- JSON serialization
- HTTP clients
- Background services

### Build:

- REST API consumer
- CLI application using external APIs
- Small service that reads and writes data

## Phase 3: Learn HTTP and Web Basics

### Topics:

- HTTP methods (GET, POST, PUT, DELETE)
- Headers
- Status codes
- JSON
- Authentication
- Cookies
- JWTs
- Browser/server architecture

Build:

- Use Postman or Bruno
- Call public APIs
- Create requests manually

## Phase 4: Learn ASP.NET Core Web APIs

This is where web development starts.

Use ASP.NET Core to build APIs only.

### Topics:

- Controllers
- Routing
- Model binding
- Validation
- Dependency Injection
- Middleware
- Authentication
- Entity Framework Core

### Build:

- Todo API
- Notes API
- Blog backend
- E-commerce backend

You should become comfortable building APIs before touching frontend frameworks.

## Phase 5: Learn Databases

Database skills matter regardless of whether you choose Blazor, MAUI, React, Angular, or something else.

### Topics:

- SQL
- Joins
- Indexes
- Relationships
- Normalization
- Entity Framework Core

### Build:

- User management
- Product catalog
- Order system

Recommended database:

- PostgreSQL

## Phase 6: Choose Your UI Path

At this point, branch based on your interests.

### Option A: Blazor

Learn:

- Components
- State management
- Forms
- Routing
- API integration

Build:

- Notes app
- Budget tracker
- Dashboard

Blazor is attractive because you stay in C# almost entirely.

Relevant technology:

- Blazor

### Option B: Traditional Frontend

Learn:

- HTML
- CSS
- JavaScript
- A frontend framework

Then use ASP.NET Core as the backend.

This path gives the largest job market.

Relevant technologies:

- ASP.NET Core
- React
- Angular

## Phase 7: Learn MAUI

Intentionally delay MAUI until after you've built at least one API and one web application.

Why?

MAUI combines:

- C#
- XAML
- UI development
- Mobile concepts
- Device APIs
- Application lifecycle

Learning it too early means debugging five different things at once.

### Topics:

- XAML
- MVVM
- Navigation
- Data binding
- Local storage
- API integration

### Build:

- Notes app
- Habit tracker
- Expense tracker

Relevant technology:

- .NET MAUI


## Base prompt for project checking by AI:

I am learning C# and .NET through a structured roadmap. I am currently working through projects designed to teach specific concepts, and my goal is to understand the language and the reasoning behind design choices rather than simply making the project work.

Project Information:
[PASTE PROJECT DESCRIPTION HERE]

My Code:
[PASTE CODE HERE]

Please review my solution as if you were a senior C# developer mentoring a junior developer.

Evaluate the following:

1. Correctness

   * Does the code work as intended?
   * Are there any bugs, edge cases, or logical errors?

2. C# Fundamentals

   * Am I using the language features appropriately?
   * Are there any opportunities to use better C# practices?

3. Project Goals

   * Based on the project description, am I focusing on the right concepts?
   * Did I miss any important learning opportunities?

4. Code Quality

   * Is the code readable and maintainable?
   * Are naming conventions appropriate?
   * Is the code organized well?

5. Next Improvement

   * What is the single most important improvement I should make next?
   * Explain why it matters.

6. Learning Feedback

   * What concepts do I appear to understand well?
   * What concepts should I study further?

Please do not rewrite the entire project unless absolutely necessary. Instead, guide me toward improvements and explain the reasoning behind them. Assume I am learning and want to understand the "why" behind your suggestions.

