using DN5CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DN5CommandAPI.Data
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) : base(options)
        {

        }
        public DbSet<Command> CommandItems { get; set; }
    }
}