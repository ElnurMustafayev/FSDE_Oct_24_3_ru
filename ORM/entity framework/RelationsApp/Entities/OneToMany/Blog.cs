using System.ComponentModel.DataAnnotations;

namespace RelationsApp.Entities.OneToMany;

public class Blog
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [MaxLength(200)]
    public Uri? SiteUri { get; set; }

    public ICollection<Post>? Posts { get; set; }
}