using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SchoolSystem.Infrastructure.Data.Configuration
{
    internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(new Teacher()
            {
                Id = 1,
                FirstName = "Zdravka",
                LastName = "Iordanova",
                Topic = "Утре урокът ще бъде за окръжности!Приятна вечер."
            });
        }
    }
}
