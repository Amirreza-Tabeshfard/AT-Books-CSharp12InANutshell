namespace PrimaryConstructors.Models;

internal class Product(int id,
                       string name,
                       decimal price)
{
    public int Id { get; } = id;

    public string Name { get; } = name;

    public decimal Price { get; } = price;

    public override string ToString()
    {
        return $"{Name} : {Price:C}";
    }
}