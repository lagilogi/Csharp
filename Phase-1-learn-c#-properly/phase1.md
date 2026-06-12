## Project 1: Console Calculator

Learn how programs receive input, process data, and produce output. This is the first time you'll see the complete flow:

Input -> Logic -> Output

which is the foundation of almost every application you'll ever build.

### Concepts to Learn

- Variables
- Primitive types
- int
- double
- bool
- string
- Console input/output
- Operators
- if/else
- switch
- methods
- loops
- input validation

### By the end, you should be able to answer:

- Why choose double instead of int?
- What's the difference between == and =?
- When should logic go into a method?
- How do you prevent crashes from bad user input?

### Stretch Goal - Refactor calculation logic into separate methods:

- Add()
- Subtract()
- Multiply()
- Divide()


## Project 2: Todo List

Learn how programs manage collections of data. Most real applications aren't calculators. They're collections of things:

- users
- tasks
- products
- orders

This project introduces that idea.

### Concepts to Learn

- Lists
- Loops
- Classes
- Objects
- Basic CRUD

CRUD means:

- Create
- Read
- Update
- Delete

Example Class

```csharp
class TodoItem
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
}
```

### What to Focus On and understand

- What is an object?
- Why use a class instead of multiple variables?
- Why is a List useful?

### Stretch Goal

- Save tasks to a file.

## Project 3: File Organizer

Learn how programs interact with the operating system. Most beginner projects stay entirely in memory. Real software reads and writes files.

### Concepts to Learn

- File I/O
- Directories
- Paths
- Exception handling
- String manipulation

Example

Move:

Downloads/
    image.jpg
    report.pdf
    notes.txt

into:

Downloads/
    Images/
    PDFs/
    Text/

### What to Focus On and Learn

- File
- Directory
- Path

and:

```csharp
try
{
}
catch
{
}
```

This is where exceptions become practical.

### Stretch Goal

- Create folders automatically.

## Project 4: Inventory Manager

Learn object-oriented programming properly. This is where C# starts feeling like C#.

### Concepts to Learn

- Classes
- Constructors
- Encapsulation
- Properties
- Collections of objects

Example Class

```csharp
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
```

### What to Focus On and Understand

- Why classes exist
- How instances work
- Why objects represent real-world concepts

### Stretch Goal

- Search products by name.

## Project 5: Weather API Client

Learn how modern applications communicate over the internet. This is your bridge into web development.

### Concepts to Learn

- HTTP requests
- JSON
- Serialization
- Async/await
- External APIs

Example Flow

```csharp
User enters city
↓
Call weather API
↓
Receive JSON
↓
Convert JSON to C# objects
↓
Display weather
```

### What to Focus On and Learn

- HttpClient
- async
- await

These are essential skills for ASP.NET and MAUI later.

### Stretch Goal

- Display a 5-day forecast.

## Project 6: Personal Expense Tracker

Combine everything learned so far. This should feel noticeably easier than Project 1.

### Concepts to Practice

- Classes
- Lists
- File storage
- LINQ
- Methods
- Validation
- Object-oriented design

Example Class

```csharp
class Expense
{
    public string Category { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}
```

Features

- Add expense
- View expenses
- Delete expense
- Show total spending
- Show spending by category

### What to Focus On

Start asking:

- How should I structure this?
- Which class owns this responsibility?
- How can I make this easier to maintain?

This is your first step toward software design.

## What You Should Know After Phase 1

Before moving to Phase 2, you should be comfortable with:

Core Language
- Variables
- Methods
- Classes
- Properties
- Constructors
- Interfaces (basic understanding)
- Generics
- Collections

Control Flow
- if/else
- switch
- for
- foreach
- while

Error Handling
- Exceptions
- Validation

Data
- Objects
- Lists
- Dictionaries
- JSON

Modern C#
- LINQ
- Async/await

.NET Basics
- NuGet packages
- Creating/running projects
- Reading documentation
