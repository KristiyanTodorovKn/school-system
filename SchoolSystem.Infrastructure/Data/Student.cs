using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Infrastructure.Data
{
    public class Student
    {
        public Student()
        {
            Subjects = new List<Subject>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;

        public int Class { get; set; }

        public ICollection<Subject> Subjects { get; set; }
    }
}
