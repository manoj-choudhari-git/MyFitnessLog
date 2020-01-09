using Microsoft.EntityFrameworkCore;
using MyFitnessLog.Data.Models.Entities;

namespace MyFitnessLog.Data.Models
{
    public class MyFitnessLogContext : DbContext
    {
        public MyFitnessLogContext(DbContextOptions<MyFitnessLogContext> options)
            : base(options)
        {
        }

        public DbSet<WorkoutLog> Workouts { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkoutLog>().ToTable("Workouts");
        }
    }
}
