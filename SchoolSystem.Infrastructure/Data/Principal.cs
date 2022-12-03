using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Infrastructure.Data
{
    public class Principal
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [Required]
        public int SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public School School { get; set; }
    }
}
