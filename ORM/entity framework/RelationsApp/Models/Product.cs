namespace RelationsApp.Models;

public class Product
{
    public int ProductIdentifier { get; set; }
    public required string Code { get; set; }
    public required string Name { get; set; }

    public override string ToString() => $"{ProductIdentifier} {Code} {Name}";
}