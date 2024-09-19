using System.ComponentModel.DataAnnotations;

namespace BurgerMongoDB.DTOs
{
    public class registerDTO
    {
        [Required]
        public string name { get; set; } = string.Empty;
        [Required]
        public string email { get; set; } = string.Empty;
        [Required]
        public string password { get; set; } = string.Empty;
        [Required, Compare(nameof(password))]
        public string confirmPass { get; set; } = string.Empty;
    }
}
