using System.Text.Json;

namespace TodoApp
{
    public class JsonTodoRepository : ITodoRepository
    {
        private readonly JsonSerializerOptions _saveOptions = new JsonSerializerOptions { WriteIndented = true };
        private readonly string _filePath = "./todo.json";

        public List<Todo> LoadTodos()
        {
            if (File.Exists(_filePath))
            {
                string readTodos = File.ReadAllText(_filePath);
                List<Todo> loadedList = JsonSerializer.Deserialize<List<Todo>>(readTodos) ?? [];
                return loadedList;
            }

            return new List<Todo>();
        }

        public void SaveTodos(List<Todo> todos)
        {
            string jsonString = JsonSerializer.Serialize(todos, _saveOptions);
            File.WriteAllText(_filePath, jsonString);
        }
    }
}
