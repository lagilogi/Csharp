namespace TodoApp
{
    static class Program
    {
        static void Main()
        {
            JsonTodoRepository repo = new();

            TodoHandler todoHandler = new(repo);

            ConsoleUI.PrintMessage("\n** Welcome to the Console Todo app. These are your available commands:");
            ConsoleUI.PrintCommands();

            string input;
            while (true)
            {
                ConsoleUI.PrintMessage("\nWhat would you like to do?");
                input = ConsoleUI.GetInput();
                if (string.IsNullOrEmpty(input)) {
                    ConsoleUI.PrintMessage("Error: invalid input - Input cannot be empty");
                    continue;
                }
                input = input.ToUpper();
                switch (input) {
                    case "ADD":
                    case "1":
                        ConsoleUI.PrintMessage("\n** Adding to-do **");
                        todoHandler.AddTodo();
                        break;
                    case "DELETE":
                    case "2":
                        ConsoleUI.PrintMessage("\n** Deleting to-do **");
                        todoHandler.GetIdInput(IdAction.DELETE);
                        break;
                    case "COMPLETE":
                    case "3":
                        ConsoleUI.PrintMessage("\n** Completing to-do **");
                        todoHandler.GetIdInput(IdAction.COMPLETE);
                        break;
                    case "LIST":
                    case "4":
                        ConsoleUI.PrintMessage("\n** Listing single to-do **");
                        todoHandler.GetIdInput(IdAction.LIST);
                        break;
                    case "LISTSOME":
                    case "5":
                        ConsoleUI.PrintMessage("\n** Listing some to-dos **");
                        todoHandler.ListTodos(false);
                        break;
                    case "LISTALL":
                    case "6":
                        ConsoleUI.PrintMessage("\n** Listing all to-dos **");
                        todoHandler.ListTodos(true);
                        break;
                    case "COMMANDS":
                    case "HELP":
                    case "7":
                        ConsoleUI.PrintCommands();
                        break;
                    case "EXIT":
                    case "8":
                        ConsoleUI.PrintMessage("\nExiting program ..");
                        return;
                    default:
                        ConsoleUI.PrintMessage("\nError: Invalid command");
                        continue;
                }
            }
        }
    }
}
