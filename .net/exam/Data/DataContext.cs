namespace exam;
using Microsoft.EntityFrameworkCore;


public class DataContext : DbContext
{

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<One> Ones { get; set; }

    public DbSet<Many> Manys { get; set; }

    //* Initial data

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<User>().HasData(
    //         new User { Id = 1, Name = "User 1", Description = "Description 1" },
    //         new User { Id = 2, Name = "User 2", Description = "Description 2" },
    //         new User { Id = 3, Name = "User 3", Description = "Description 3" }
    //     );

    //     modelBuilder.Entity<One>().HasData(
    //         new One { Id = 1, Name = "One 1", Description = "Description 1" },
    //         new One { Id = 2, Name = "One 2", Description = "Description 2" },
    //         new One { Id = 3, Name = "One 3", Description = "Description 3" }
    //     );

    //     modelBuilder.Entity<Many>().HasData(
    //         new Many { Id = 1, Name = "Many 1" },
    //         new Many { Id = 2, Name = "Many 2" },
    //         new Many { Id = 3, Name = "Many 3" }
    //     );
    // }


}
