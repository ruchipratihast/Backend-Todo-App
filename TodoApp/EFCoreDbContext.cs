using Microsoft.EntityFrameworkCore;
using TodoApp.Models.Database;

namespace TodoApp
{
    public class EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : DbContext(options)
    {
        public DbSet<TodoModel> TodoModel { get; set; }
    }
}
