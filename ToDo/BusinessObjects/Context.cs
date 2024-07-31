using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ToDo.Configurations;

namespace ToDo.BusinessObjects
{
    public class Context : DbContext
    {
        private readonly DataBaseConfiguration _dbConfiguration;

        public Context(DataBaseConfiguration dbConfiguration)
        {
            _dbConfiguration = dbConfiguration;
        }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<SubTask> SubTasks { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConfiguration.ConnectionString);
        }
    }
}
