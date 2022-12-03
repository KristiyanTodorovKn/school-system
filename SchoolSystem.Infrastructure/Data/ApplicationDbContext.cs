using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Infrastructure.Data.Configuration;

namespace SchoolSystem.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new SchoolConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new ParentConfiguration());
            builder.ApplyConfiguration(new SubjectConfiguration());
            builder.ApplyConfiguration(new PrincipalConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<Teacher> Teachers { get; set; } = null!;

        public DbSet<Student> Students { get; set; } = null!;

        public DbSet<Parent> Parents { get; set; } = null!;

        public DbSet<Subject> Subjects { get; set; } = null!;

        public DbSet<Principal> Principals { get; set; } = null!;

        public DbSet<School> Schools { get; set; } = null!;
    }
}
