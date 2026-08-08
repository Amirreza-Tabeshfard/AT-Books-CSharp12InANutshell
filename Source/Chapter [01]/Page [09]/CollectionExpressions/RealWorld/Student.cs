namespace CollectionExpressions.RealWorld;
/// <summary>
/// Represents a student in the examples.
/// This class is intentionally simple so that the focus
/// remains on Collection Expressions.
/// </summary>
internal class Student
{
    public int Id { get; }

    public string FullName { get; }

    public int Age { get; }

    public string Major { get; }

    public Student(int id, string fullName)
    {
        Id = id;
        FullName = fullName;
        Age = 0;
        Major = "Unknown";
    }

    public Student(int id, string fullName, int age, string major)
    {
        Id = id;
        FullName = fullName;
        Age = age;
        Major = major;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {FullName}, Age: {Age}, Major: {Major}";
    }
}