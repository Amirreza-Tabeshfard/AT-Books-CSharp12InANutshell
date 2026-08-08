namespace PrimaryConstructors.Models;

internal class University(string name,
                          string city)
{
    public string Name { get; } = name;

    public string City { get; } = city;

    public override string ToString()
    {
        return $"{Name} ({City})";
    }
}