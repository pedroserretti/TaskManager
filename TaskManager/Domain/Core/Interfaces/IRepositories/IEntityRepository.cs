namespace TaskManager.Domain.Core.Interfaces.IRepositories {
    public interface IEntityRepository<TEntity> where TEntity : class {

        void AddTask(TEntity entity);
        void UpdateTask(TEntity entity);
        void DeleteTask(TEntity entity);
        void GetTask(TEntity entity);
    }
}
