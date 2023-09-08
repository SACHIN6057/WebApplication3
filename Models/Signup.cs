
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace WebApplication3.Models
{
    public class Signup
    {

        [Key] 
        public string? Username { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Password { get; set; }
      
        public DateTime CreatedDateTime { get; set; }

    }
}
