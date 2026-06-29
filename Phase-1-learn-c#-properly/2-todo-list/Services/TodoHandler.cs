namespace TodoApp
{
    public class TodoHandler {
        private readonly List<Todo>         _todoList;
        private readonly ITodoRepository    _todoRepo;
        private int                         _lastId;

        // Constructor - Also adding first todo for example purposes
        public TodoHandler(ITodoRepository repo)
        {
            Console.WriteLine("TodoHandler initializing..");
            _todoRepo = repo;
            _todoList = _todoRepo.LoadTodos();

            if (_todoList.Count == 0)
            {
                _lastId = 0;
                AddTodo("My first todo");
                _todoRepo.SaveTodos(_todoList);
            }
            else
            {
                _lastId = GetLastId();
            }
        }

        private void AddTodo(string todoTitle)
        {
            _todoList.Add(new Todo(_lastId, todoTitle, false));
        }
        public void AddTodo()
        {
            string input;
            string command;
            Console.WriteLine("Enter to-do title, or [EXIT] to return to menu");
            while (true)
            {
                Console.Write("> ");
                input = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(input)) {
                    Console.WriteLine("Invalid input: Input cannot be empty");
                    continue;
                }
                command = input.ToUpper();
                if (command == "EXIT")
                    return;
                else
                    break;
            }
            int newId = IncreaseTodoId();
            _todoList.Add(new Todo(newId, input, false));
            _todoRepo.SaveTodos(_todoList);
            Console.WriteLine($"\n[ADDED] ID {newId}: {input} - Not completed");
        }

        private void DeleteTodo(Todo todo)
        {
            _todoList.Remove(todo);
            _todoRepo.SaveTodos(_todoList);
            Console.WriteLine($"\n[DELETED] ID {todo.Id}: {todo.Title}");
        }

        private void CompleteTodo(Todo todo)
        {
            todo.MarkCompleted();
            _todoRepo.SaveTodos(_todoList);
            Console.WriteLine($"\n[COMPLETED] ID {todo.Id}: {todo.Title}");
        }

        private static void PrintTodo(Todo todo)
        {
            if (todo.IsCompleted)
                Console.WriteLine($"ID {todo.Id}: {todo.Title} - Completed");
            else
                Console.WriteLine($"ID {todo.Id}: {todo.Title} - Not completed");
        }

        public void ListTodos(bool listAll)
        {
            if (_todoList.Count == 0)
            {
                Console.WriteLine("\nThe to-do list is emtpy ..");
                return;
            }

            if (listAll)
            {
                foreach(Todo todo in _todoList)
                    PrintTodo(todo);
            }
            else
            {
                string input;
                Console.WriteLine("Enter [C] to list completed, [U] to list only uncompleted, [EXIT] to return to menu");
                while (true)
                {
                    Console.Write("> ");
                    input = Console.ReadLine() ?? "";
                    if (string.IsNullOrEmpty(input)) {
                        Console.WriteLine("Invalid input: Input cannot be empty");
                        continue;
                    }
                    input = input.ToUpper();
                    if (input == "EXIT")
                        return;
                    else if (input == "C" || input == "U")
                        break;
                    Console.WriteLine("Error: Invalid input");
                }
                for (int i = 0; i < _todoList.Count; i++)
                {
                    if (input == "C" && _todoList[i].IsCompleted)
                        PrintTodo(_todoList[i]);
                    else if (input == "U" && !_todoList[i].IsCompleted)
                        PrintTodo(_todoList[i]);
                }
            }
        }

        public void ListAllTodos()
        {
            if (_todoList.Count == 0)
            {
                Console.WriteLine("\nThe to-do list is emtpy ..");
                return;
            }

            foreach(Todo todo in _todoList)
            {
                PrintTodo(todo);
            }
        }

        public void GetIdInput(IdAction idAction) {
            string input;
            IdAction action = idAction;
            int todoIndex;
            while (true)
            {
                Console.WriteLine("Enter ID, [LISTALL] to show all to-dos, or [EXIT] to return to menu");
                Console.Write("> ");
                input = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(input)) {
                    Console.WriteLine("Error: invalid input - Input cannot be empty");
                    continue;
                }
                else if (int.TryParse(input, out int id))
                {
                    todoIndex = FindTodoIndex(id);
                    if (todoIndex != -1)
                    {
                        switch (action)
                        {
                            case IdAction.DELETE:
                                DeleteTodo(_todoList[todoIndex]);
                                return;
                            case IdAction.COMPLETE:
                                CompleteTodo(_todoList[todoIndex]);
                                return;
                            case IdAction.LIST:
                                PrintTodo(_todoList[todoIndex]);
                                return;
                        }
                    }
                    Console.WriteLine($"ERROR: Could not find ID {id}");
                    continue;
                }
                input = input.ToUpper();
                if (input == "LISTALL")
                    ListAllTodos();
                else if (input == "EXIT")
                    return;
                else
                    Console.WriteLine("Error: Invalid input");
            }
        }

        private int IncreaseTodoId()
        {
            return ++_lastId;
        }

        private int FindTodoIndex(int id)
        {
            for (int i = 0; i < _todoList.Count; i++)
            {
                if (_todoList[i].Id == id)
                    return i;
            }
            return -1;
        }

        private int GetLastId()
        {
            return _todoList.Max(todo => todo.Id);
        }
    }
}
