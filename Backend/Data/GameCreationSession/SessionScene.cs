using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[PrimaryKey(nameof(SceneId))]
public class SessionScene
{
    public int SceneId { get; set; }

    [ForeignKey(nameof(GameCreationSession))]
    public string? SessionId { get; set; }
}