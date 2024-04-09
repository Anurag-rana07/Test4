using System.ComponentModel.DataAnnotations;

namespace Test4.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Class is required")]
        public string Class { get; set; }

        public List<string> Languages { get; set; }
    }
}

