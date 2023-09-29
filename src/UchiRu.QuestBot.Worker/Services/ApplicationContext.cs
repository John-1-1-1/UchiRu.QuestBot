using Microsoft.EntityFrameworkCore;
using UchiRu.QuestBot.Worker.DbTables;

namespace UchiRu.QuestBot.Worker.Services; 

public sealed class ApplicationContext: DbContext {
    public DbSet<User> Users { get; set; } = null!;
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}