namespace RelationsApp.Entities.ManyToMany;

public class Post
{
    public int Id { get; set; }
    public List<PostTag> PostTags { get; } = [];
}