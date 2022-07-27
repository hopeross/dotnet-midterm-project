using Microsoft.EntityFrameworkCore;
using midterm_project.Models;

namespace midterm_project.Migrations;
public class PetDbContext : DbContext {
    public DbSet<Pet> Pet { get; set; }

    public PetDbContext(DbContextOptions<PetDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder){

    }
}






// using l07_assignment.Models;
// using Microsoft.EntityFrameworkCore;

// namespace l07_assignment.Migrations;

// public class JobDbContext : DbContext{
//     public DbSet<Job> Job { get; set; }

//     public JobDbContext(DbContextOptions<JobDbContext> options) : base(options) {}

//     protected override void OnModelCreating(ModelBuilder modelBuilder) {
//         base.OnModelCreating(modelBuilder);

//         modelBuilder.Entity<Job>(entity =>
//         {
//             entity.HasKey(e => e.JobId);
//             entity.Property(e => e.JobTitle).IsRequired();
//             entity.Property(e => e.JobDescription).IsRequired();
//             entity.Property(e => e.CompanyName).IsRequired();
//             entity.Property(e => e.YearsWorked).IsRequired();
//         });
//     }
// }