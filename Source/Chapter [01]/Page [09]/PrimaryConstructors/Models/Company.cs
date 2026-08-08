namespace PrimaryConstructors.Models;

internal class Company(string name,
                       string country)
{
    public string Name { get; } = name;

    public string Country { get; } = country;

    public override string ToString()
    {
        return $"{Name} ({Country})";
    }
}