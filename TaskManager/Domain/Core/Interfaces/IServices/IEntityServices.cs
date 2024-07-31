namespace TaskManager.Domain.Core.Interfaces.IServices {
    public interface IEntityServices<TEntity> where TEntity : class {

        void AddTask(TEntity entity);
        void UpdateTask(TEntity entity);
        void DeleteTask(TEntity entity);
        void GetTask(TEntity entity);
    }
}
