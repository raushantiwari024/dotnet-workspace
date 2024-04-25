using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DatabaseTest.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("Student Name")]
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}