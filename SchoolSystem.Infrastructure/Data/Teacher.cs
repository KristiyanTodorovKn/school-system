using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Infrastructure.Data
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(30)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string Topic { get; set; } = null!;
    }
}
