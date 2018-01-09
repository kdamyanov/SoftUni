using Judge.App.Infrastructure.Validation;

namespace Judge.App.Models.Users
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
