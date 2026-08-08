namespace PrimaryConstructors.Models;

internal class Teacher(int id,
                       string firstName,
                       string lastName,
                       string department)
{
    public int Id { get; } = id;

    public string FirstName { get; } = firstName;

    public string LastName { get; } = lastName;

    public string Department { get; } = department;

    public override string ToString()
    {
        return $"{Id} | {FirstName} {LastName} | {Department}";
    }
}