namespace PrimaryConstructors.Models;

internal class Address(string country,
                       string city,
                       string street)
{
    public string Country { get; } = country;

    public string City { get; } = city;

    public string Street { get; } = street;

    public override string ToString()
    {
        return $"{Country}, {City}, {Street}";
    }
}