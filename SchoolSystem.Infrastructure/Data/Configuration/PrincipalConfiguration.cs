using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SchoolSystem.Infrastructure.Data.Configuration
{
    internal class PrincipalConfiguration : IEntityTypeConfiguration<Principal>
    {
        public void Configure(EntityTypeBuilder<Principal> builder)
        {
            builder.HasData(new Principal()
            {
                Id = 1,
                FirstName = "Aleksandra",
                LastName = "Stankova",
                SchoolId = 1
            });
        }
    }
}
