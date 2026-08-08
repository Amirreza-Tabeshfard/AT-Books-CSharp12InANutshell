namespace PrimaryConstructors.Models;

internal class Manager(int id,
                       string fullName,
                       decimal salary,
                       string department)
{
    public int Id { get; } = id;

    public string FullName { get; } = fullName;

    public decimal Salary { get; } = salary;

    public string Department { get; } = department;

    public override string ToString()
    {
        return $"{Id} | {FullName} | {Department}";
    }
}