namespace TodoApp.Models.Request
{
    public class CreateTodoRequest
    {
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
    }

    public class UpdateTodoRequest
    {
        public Guid Id { get; set; }
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }

    }
}
