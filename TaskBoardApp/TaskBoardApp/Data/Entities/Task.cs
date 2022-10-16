namespace TaskBoardApp.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using static TaskBoardApp.Data.DataConstants.Task;

    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxTaskTitle, MinimumLength = MinTaskTitle)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(MaxTaskDescription, MinimumLength = MinTaskDescription)]
        public string Description { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public int BoardId { get; set; }

        public Board Board { get; set; }

        // The Id of the Owner (User) is string because by default IdentityUser class has strings for ids
        [Required]
        public string OwnerId { get; set; }

        public User Owner { get; set; }
    }
}
