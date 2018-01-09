namespace Judge.App.Models.Contest
{
    using System.ComponentModel.DataAnnotations;
    using Infrastructure.Validation.Contests;

    class ContestModel
    {
        [Required]
        [Contest]
        public string Name { get; set; }
    }
}
