namespace TaskBoardApp.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using static TaskBoardApp.Data.DataConstants.User;

    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxUserFirstName)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(MaxUserLastName)]
        public string LastName { get; set; } = null!;
    }
}
