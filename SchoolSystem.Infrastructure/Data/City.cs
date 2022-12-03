using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Infrastructure.Data
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; } = null!;
    }
}
