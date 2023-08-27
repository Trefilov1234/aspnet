using System.ComponentModel.DataAnnotations.Schema;

namespace lesson_2.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? BirthDate { get; set; }
    }
}
