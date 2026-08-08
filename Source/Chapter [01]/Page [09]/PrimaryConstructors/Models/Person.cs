namespace PrimaryConstructors.Models;

/// <summary>
/// Represents a basic person.
/// </summary>
internal class Person(int id,
                      string firstName,
                      string lastName)
{
    public int Id { get; } = id;

    public string FirstName { get; } = firstName;

    public string LastName { get; } = lastName;

    public string FullName => $"{FirstName} {LastName}";

    public override string ToString()
    {
        return $"{Id} | {FullName}";
    }
}