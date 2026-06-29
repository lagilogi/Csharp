namespace TodoApp
{
    static class Program
    {
        static void Main()
        {
            JsonTodoRepository repo = new();

            TodoHandler todoHandler = new(repo);

            Console.WriteLine("\n** Welcome to the Console Todo app. These are your available commands:");
            ListCommands();

            string input;
            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.Write("> ");
                input = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(input)) {
                    Console.WriteLine("Error: invalid input - Input cannot be empty");
                    continue;
                }
                input = input.ToUpper();
                switch (input) {
                    case "ADD":
                    case "1":
                        Console.WriteLine("\n** Adding to-do **");
                        todoHandler.AddTodo();
                        break;
                    case "DELETE":
                    case "2":
                        Console.WriteLine("\n** Deleting to-do **");
                        todoHandler.GetIdInput(IdAction.DELETE);
                        break;
                    case "COMPLETE":
                    case "3":
                        Console.WriteLine("\n** Completing to-do **");
                        todoHandler.GetIdInput(IdAction.COMPLETE);
                        break;
                    case "LIST":
                    case "4":
                        Console.WriteLine("\n** Listing single to-do **");
                        todoHandler.GetIdInput(IdAction.LIST);
                        break;
                    case "LISTSOME":
                    case "5":
                        Console.WriteLine("\n** Listing some to-dos **");
                        todoHandler.ListTodos(false);
                        break;
                    case "LISTALL":
                    case "6":
                        Console.WriteLine("\n** Listing all to-dos **");
                        todoHandler.ListTodos(true);
                        break;
                    case "COMMANDS":
                    case "HELP":
                    case "7":
                        ListCommands();
                        break;
                    case "EXIT":
                    case "8":
                        Console.WriteLine("\nExiting program ..");
                        return;
                    default:
                        Console.WriteLine("\nError: Invalid command");
                        continue;
                }
            }
        }

        static void ListCommands()
        {
            Console.WriteLine("\n1. [ADD] to add a new todo\n2. [DELETE] to delete a todo\n3. [COMPLETE] to mark a todo as completed\n4. [LIST] to list a single todo\n5. [LISTSOME] to list some todos\n6. [LISTALL] to list all todos\n7. [COMMANDS] to list all commands again\n8. [EXIT] to exit the program");
        }
    }
}
