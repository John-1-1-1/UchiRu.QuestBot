using Microsoft.EntityFrameworkCore;
using UchiRu.QuestBot.Worker.DbTables;

namespace UchiRu.QuestBot.Worker.Services; 

public sealed class ApplicationContext: DbContext {
    public DbSet<User> Users { get; set; } = null!;

    public ApplicationContext() {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        string connection = "Server=127.0.0.1;User Id=postgres;Password=postgres;Port=5432;Database=UserDB;";
        optionsBuilder.UseNpgsql(connection);
    }
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) {
        Database.EnsureCreated();
    }
}