using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SchoolSystem.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(CreateUsers());
        }
        private List<IdentityUser> CreateUsers()
        {
            var users = new List<IdentityUser>();
            var hasher = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "kamen_kovachev@mail.com",
                NormalizedUserName = "kamen_kovachev@mail.com",
                Email = "kamen_kovachev@mail.com",
                NormalizedEmail = "kamen_kovachev@mail.com"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "kamen123");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "aleksandra_stankova@mail.com",
                NormalizedUserName = "aleksandra_stankova@mail.com",
                Email = "aleksandra_stankova@mail.com",
                NormalizedEmail = "aleksandra_stankova@mail.com"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "aleksandra123");

            users.Add(user);

            return users;
        }
    }
}
