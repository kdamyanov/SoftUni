namespace Judge.App.Models.Users
{
    using System.ComponentModel.DataAnnotations;
    using Infrastructure.Validation.Users;

    public class RegisterModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [Email]
        public string Email { get; set; }

        [MaxLength(20)]
        public string FullName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [Password]
        public string Password { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string ConfirmPassword { get; set; }

        
    }
}
