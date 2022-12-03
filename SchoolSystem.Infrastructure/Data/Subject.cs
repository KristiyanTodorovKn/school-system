using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SchoolSystem.Infrastructure.Data
{
    public class Subject
    {
        public Subject()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public int Grade { get; set; }

        public List<Teacher> Teachers { get; set; }

        [Required]
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public ICollection<Student> Students { get; set; }
    }
}
