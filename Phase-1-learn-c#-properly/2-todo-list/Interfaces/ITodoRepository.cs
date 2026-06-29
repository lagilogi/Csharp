namespace TodoApp
{
    public interface ITodoRepository
    {
        List<Todo>    LoadTodos();
        void          SaveTodos(List<Todo> todos);
    }
}
