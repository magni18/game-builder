using Microsoft.EntityFrameworkCore;

public class GameCreationSessionContext : DbContext
{
    public DbSet<GameCreationSession> CreationSessions { get; set; }

    public string DbPath { get; }

    public GameCreationSessionContext()
    {
        var path = "./";
        DbPath = Path.Join(path, "game_creation_sessions.db");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}