using System.ComponentModel.DataAnnotations;

namespace RelationsApp.Entities.OneToMany; 

public class Post
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateOnly PublishedOn { get; set; }
    public bool Archived { get; set; }

    public int BlogId { get; set; }
    public Blog? Blog { get; set; }
}