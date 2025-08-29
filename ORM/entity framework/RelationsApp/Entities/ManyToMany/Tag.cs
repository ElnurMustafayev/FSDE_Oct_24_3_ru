namespace RelationsApp.Entities.ManyToMany;

public class Tag
{
    public int Id { get; set; }
    public List<PostTag> PostTags { get; } = [];
}