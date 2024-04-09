using System.ComponentModel.DataAnnotations;

namespace Test4.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Sex is required")]
        public string Sex { get; set; }

        public string ImageUrl { get; set; }
    }
}

