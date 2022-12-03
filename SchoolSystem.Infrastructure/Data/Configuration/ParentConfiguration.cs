using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SchoolSystem.Infrastructure.Data.Configuration
{
    internal class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            builder.HasData(new Parent()
            {
                Id = 1,
                FirstName = "Dimitar",
                LastName = "Kovachev",
                StudentId = 1
            });
        }
    }
}
