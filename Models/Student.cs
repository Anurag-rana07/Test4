using System.ComponentModel.DataAnnotations;

namespace Test4.Models
{
    public class Student
    {
            public int Id { get; set; }

            [Required(ErrorMessage = "Name is required")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Age is required")]
            public int Age { get; set; }

            public string ImageUrl { get; set; }

            public string Class { get; set; }

            [Required(ErrorMessage = "Roll number is required")]
            public int RollNumber { get; set; }
    }
}
