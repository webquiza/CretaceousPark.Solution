using Microsoft.EntityFrameworkCore;

namespace CretaceousPark.Models
{
  public class CretaceousParkContext : DbContext
  {
    public CretaceousParkContext(DbContextOptions<CretaceousParkContext> options)
      : base(options)
      {
      }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Name = "Matilda", Species = "Woolly Mammoth", Age = 7, Gender = "Female", PageNumber = 1 },
            new Animal { AnimalId = 2, Name = "Rexie", Species = "Dinosaur", Age = 10, Gender = "Female", PageNumber = 2},
            new Animal { AnimalId = 3, Name = "Matilda", Species = "Dinosaur", Age = 2, Gender = "Female", PageNumber = 3 },
            new Animal { AnimalId = 4, Name = "Pip", Species = "Shark", Age = 4, Gender = "Male", PageNumber = 4 },
            new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male", PageNumber = 5 }
          );
      }

      public DbSet<Animal> Animals { get; set; }
  }
}