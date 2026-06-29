namespace TodoApp
{
    public class TodoHandler {
        private readonly List<Todo>         _todoList;
        private readonly ITodoRepository    _todoRepo;
        private int                         _lastId;

        // Constructor - Also adding first todo for example purposes
        public TodoHandler(ITodoRepository repo)
        {
            ConsoleUI.PrintMessage("TodoHandler initializing..");
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
            ConsoleUI.PrintMessage("Enter to-do title, or [EXIT] to return to menu");
            while (true)
            {
                input = ConsoleUI.GetInput();
                if (string.IsNullOrEmpty(input)) {
                    ConsoleUI.PrintMessage("Invalid input: Input cannot be empty");
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
            ConsoleUI.PrintMessage($"\n[ADDED] ID {newId}: {input} - Not completed");
        }

        private void DeleteTodo(Todo todo)
        {
            _todoList.Remove(todo);
            _todoRepo.SaveTodos(_todoList);
            ConsoleUI.PrintMessage($"\n[DELETED] ID {todo.Id}: {todo.Title}");
        }

        private void CompleteTodo(Todo todo)
        {
            todo.MarkCompleted();
            _todoRepo.SaveTodos(_todoList);
            ConsoleUI.PrintMessage($"\n[COMPLETED] ID {todo.Id}: {todo.Title}");
        }

        private static void PrintTodo(Todo todo)
        {
            if (todo.IsCompleted)
                ConsoleUI.PrintMessage($"ID {todo.Id}: {todo.Title} - Completed");
            else
                ConsoleUI.PrintMessage($"ID {todo.Id}: {todo.Title} - Not completed");
        }

        public void ListTodos(bool listAll)
        {
            if (_todoList.Count == 0)
            {
                ConsoleUI.PrintMessage("\nThe to-do list is emtpy ..");
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
                ConsoleUI.PrintMessage("Enter [C] to list completed, [U] to list only uncompleted, [EXIT] to return to menu");
                while (true)
                {
                    input = ConsoleUI.GetInput();
                    if (string.IsNullOrEmpty(input)) {
                        ConsoleUI.PrintMessage("Invalid input: Input cannot be empty");
                        continue;
                    }
                    input = input.ToUpper();
                    if (input == "EXIT")
                        return;
                    else if (input == "C" || input == "U")
                        break;
                    ConsoleUI.PrintMessage("Error: Invalid input");
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
                ConsoleUI.PrintMessage("\nThe to-do list is emtpy ..");
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
                ConsoleUI.PrintMessage("Enter ID, [LISTALL] to show all to-dos, or [EXIT] to return to menu");

                input = ConsoleUI.GetInput();
                if (string.IsNullOrEmpty(input)) {
                    ConsoleUI.PrintMessage("Error: invalid input - Input cannot be empty");
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
                    ConsoleUI.PrintMessage($"ERROR: Could not find ID {id}");
                    continue;
                }
                input = input.ToUpper();
                if (input == "LISTALL")
                    ListAllTodos();
                else if (input == "EXIT")
                    return;
                else
                    ConsoleUI.PrintMessage("Error: Invalid input");
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
