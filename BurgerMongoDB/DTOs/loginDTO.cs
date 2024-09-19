using System.ComponentModel.DataAnnotations;

namespace BurgerMongoDB.DTOs
{
    public class loginDTO
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
