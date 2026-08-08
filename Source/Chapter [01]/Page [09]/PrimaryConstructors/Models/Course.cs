namespace PrimaryConstructors.Models;

internal class Course(int id,
                      string title,
                      int units)
{
    public int Id { get; } = id;

    public string Title { get; } = title;

    public int Units { get; } = units;

    public override string ToString()
    {
        return $"{Title} ({Units} Units)";
    }
}