using Dolgozó_nyilvántartó.Repository;
using Microsoft.EntityFrameworkCore;

namespace Dolgozó_nyilvántartó.Database
{
    internal class WorkerContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        private static string projectRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
        private string DbPath = Path.Combine(projectRoot, "Resource", "Workers.db");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>()
                .Property(w => w.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Worker>()
                .Property(w => w.Name)
                .IsRequired();
            modelBuilder.Entity<Worker>()
                .Property(w => w.Email)
                .IsRequired();
            modelBuilder.Entity<Worker>()
                .Property(w => w.Age)
                .IsRequired();
            modelBuilder.Entity<Worker>()
                .Property(w => w.Salary)
                .IsRequired();
        }
    }
}
