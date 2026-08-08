namespace PrimaryConstructors.Models;

internal class Employee(int id,
                        string fullName,
                        decimal salary)
{
    public int Id { get; } = id;

    public string FullName { get; } = fullName;

    public decimal Salary { get; } = salary;

    public override string ToString()
    {
        return $"{Id} | {FullName} | {Salary:C}";
    }
}