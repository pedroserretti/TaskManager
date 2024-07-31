using Infrastructure.Data;
using TaskManager.Domain.Core.Interfaces.IRepositories;

namespace TaskManager.Infrastructure.Repositories {
    public class TaskRepositoryImpl : EntityRepositoryImpl<Task>, ITaskRepository {

        private readonly SqlContext sqlContext;

        public TaskRepositoryImpl(SqlContext sqlContext) : base(sqlContext) {
            this.sqlContext = sqlContext;
        }
    }
}
