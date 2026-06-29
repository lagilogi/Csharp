namespace TodoApp
{
    public class Todo
    {
        // Make ID only readable and forbid setting new id value
        public int Id { get; }

        // "null!" Tells the compiler that this will be assigned before anyone uses it - Suppresses the warning: Non-nullable field '_title' must contain a non-null value when exiting constructor.
        private string  _title = string.Empty;

        // Everyone can read, but only class function can modify IsCompleted property
        public bool IsCompleted { get; private set; }


        // Using a property to modify _title so we can do checks when setting the _title
        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be empty");

                _title = value;
            }
        }

        // Constructor
        public Todo(int id, string title, bool isCompleted)
        {
            Id = id;
            Title = title;
            IsCompleted = isCompleted;
        }

        // Mark todo as completed
        public void MarkCompleted()
        {
            IsCompleted = true;
        }
    }
}
