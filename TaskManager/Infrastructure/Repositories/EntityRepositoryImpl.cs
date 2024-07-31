using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Core.Interfaces.IRepositories;

namespace TaskManager.Infrastructure.Repositories {
     public class EntityRepositoryImpl<TEntity> : IEntityRepository<TEntity> where TEntity : class {

        private readonly SqlContext sqlContext;

        public EntityRepositoryImpl(SqlContext sqlContext) {
            this.sqlContext = sqlContext;
        }   

        public void AddTask(TEntity entity) {
            sqlContext.Set<TEntity>().Add(entity);
            sqlContext.SaveChanges();
        }

        public void UpdateTask(TEntity obj) {
            sqlContext.Entry(obj).State = EntityState.Modified;
            sqlContext.SaveChanges();
        }

        public void DeleteTask(TEntity entity) {
            sqlContext.Set<TEntity>().Remove(entity);
            sqlContext.SaveChanges();
        }

        public TEntity GetTask(int id) {
            return sqlContext.Set<TEntity>().Find(id)!;          
        }
    }
}
