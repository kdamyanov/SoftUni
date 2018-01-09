namespace Judge.App.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;

    public class JudgeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Contest> Contests { get; set; }

        public DbSet<Submission> Submissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder
                .UseSqlServer("Server=.;Database=JudgeDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            builder
                .Entity<User>()
                .HasMany(u => u.Contests)
                .WithOne(c => c.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}
