using Microsoft.EntityFrameworkCore;
using midterm_project.Models;

namespace midterm_project.Migrations;
public class PetDbContext : DbContext {
    public DbSet<Pet> Pet { get; set; }

    public PetDbContext(DbContextOptions<PetDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Pet>(entity => {
            entity.HasKey(e => e.PetId);
            entity.Property(e => e.PetName);
            entity.Property(e => e.PetURL);
            entity.Property(e => e.PetDescription);
            entity.Property(e => e.PetColor);
            entity.Property(e => e.PetAge);
            entity.Property(e => e.PetBreed);
            entity.Property(e => e.PetSize);
        });
    }
}