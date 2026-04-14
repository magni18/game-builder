using Microsoft.EntityFrameworkCore;

[PrimaryKey(nameof(SessionId))]
public class GameCreationSession
{
    public string? SessionId { get; set; }

    public CreationPackTypes CreationPackType { get; set; }
}