namespace TaskBoardApp.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using static TaskBoardApp.Data.DataConstants.Board;
    
    public class Board
    {
        public Board()
        {
            this.Tasks = new List<Task>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(MaxBoardName, MinimumLength = MinBoardName)]
        [Required]
        public string Name { get; set; }

        public virtual IEnumerable<Task> Tasks { get; set; }
    }
}
