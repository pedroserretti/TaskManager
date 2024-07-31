namespace TaskManager.Domain.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }
        public int DueDate { get; set; }
        public int Priority { get; set; }

        public Task(int id, int title, int description, int dueDate, int priority)
        {
            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            Priority = priority;
        }
    }
}
