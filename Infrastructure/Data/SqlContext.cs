
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data {
    public class SqlContext : DbContext {
        public SqlContext() { }
        public SqlContext(DbContextOptions options) : base(options) { }
        public DbSet<Task> Task { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    var connectionString = optionsBuilder.

        //    optionsBuilder.UseMySQL("ServerConnection");
        //}

    }
}
