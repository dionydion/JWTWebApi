using System.ComponentModel.DataAnnotations;
namespace JWTWebApiTutorial.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }

        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}

