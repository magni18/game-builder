using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[PrimaryKey(nameof(Id))]
public class SessionElementBase
{
    public int Id { get; set; }

    [ForeignKey(nameof(SessionScene))]
    public int SceneId { get; set; }
}