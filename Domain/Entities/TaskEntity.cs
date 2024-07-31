namespace TaskManager.Domain.Models {
    public class TaskEntity : Entity {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }

        public TaskEntity(int id, string title, string description, DateTime dueDate, int priority) : base(id) {
            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            Priority = priority;
        }
    }
}