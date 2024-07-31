namespace TaskManager.Domain.Models {
    abstract public class Entity(int id) {
        public int Id { get; set; } = id;
    }
}
