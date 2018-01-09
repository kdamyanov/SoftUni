using System.ComponentModel.DataAnnotations;

namespace Judge.App.Data.Models
{
    public class Contest
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
