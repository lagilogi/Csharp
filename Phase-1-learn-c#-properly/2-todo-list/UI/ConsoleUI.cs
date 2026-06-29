namespace TodoApp
{
    static class ConsoleUI
    {
        static public void PrintMessage(string message)
        {
            Console.WriteLine($"{message}");
        }

        static public string GetInput()
        {
            Console.Write("> ");
            return Console.ReadLine() ?? "";
        }

        static public void PrintCommands()
        {
            Console.WriteLine("\n1. [ADD] to add a new todo\n2. [DELETE] to delete a todo\n3. [COMPLETE] to mark a todo as completed\n4. [LIST] to list a single todo\n5. [LISTSOME] to list some todos\n6. [LISTALL] to list all todos\n7. [COMMANDS] to list all commands again\n8. [EXIT] to exit the program");
        }
    }
}
