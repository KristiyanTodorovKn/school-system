using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SchoolSystem.Infrastructure.Data.Configuration
{
    internal class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasData(new School()
            {
                Id = 1,
                Name = "Природо математическа гимназия проф. Емануил Иванов",
                Address = "ул. ”Проф. Георги Паспалев” № 11",
                CityId = 1,
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/6/63/02PMG.jpg",
                TeacherId = 1,
            });
        }
    }
}
