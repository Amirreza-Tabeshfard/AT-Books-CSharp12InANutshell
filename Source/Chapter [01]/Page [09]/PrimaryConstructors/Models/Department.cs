namespace PrimaryConstructors.Models;

internal class Department(int id,
                          string name)
{
    public int Id { get; } = id;

    public string Name { get; } = name;

    public override string ToString()
    {
        return $"{Id} | {Name}";
    }
}