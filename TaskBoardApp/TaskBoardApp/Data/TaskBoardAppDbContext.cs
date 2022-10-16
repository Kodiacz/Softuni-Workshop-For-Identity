namespace TaskBoardApp.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using TaskBoardApp.Data.Entities;

    public class TaskBoardAppDbContext : IdentityDbContext<User>
    {
        public TaskBoardAppDbContext(DbContextOptions<TaskBoardAppDbContext> options)
            : base(options)
        {
        }
    }
}