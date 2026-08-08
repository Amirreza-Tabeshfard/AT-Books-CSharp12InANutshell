namespace PrimaryConstructors.Models;

/// <summary>
/// Represents a university student.
/// </summary>
internal class Student(int id,
                       string firstName,
                       string lastName,
                       int age,
                       string major)
{
    public int Id { get; } = id;

    public string FirstName { get; } = firstName;

    public string LastName { get; } = lastName;

    public int Age { get; } = age;

    public string Major { get; } = major;

    public string FullName => $"{FirstName} {LastName}";

    public override string ToString()
    {
        return $"{Id} | {FullName} | {Age} | {Major}";
    }
}