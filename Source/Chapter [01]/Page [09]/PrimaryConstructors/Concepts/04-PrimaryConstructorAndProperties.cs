using PrimaryConstructors.Models;

namespace PrimaryConstructors.Concepts;

internal class PrimaryConstructorAndProperties
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("============================================================");
        Console.WriteLine("05 - Primary Constructor And Properties");
        Console.WriteLine("============================================================");
        Console.WriteLine();

        InitializeReadOnlyProperties();
        ReadPropertyValues();
        UseComputedProperty();
        CreateMultipleObjects();
        ComparePropertyValues();
        AccessPropertiesMultipleTimes();
        StoreObjectsInsideList();
        StoreObjectsInsideArray();
        AccessPropertiesByIndex();
        PassObjectToMethod();
        CreateObjectFromVariables();
        CreateObjectFromExpressions();
    }

    /// <summary>
    /// Demonstrates initializing read-only properties
    /// from Primary Constructor parameters.
    /// </summary>
    private void InitializeReadOnlyProperties()
    {
        Console.WriteLine("Initialize ReadOnly Properties");
        Console.WriteLine("--------------------------------------------------");

        Person person = new
        (
            1,
            "Ali",
            "Ahmadi"
        );

        Console.WriteLine($"Id         : {person.Id}");
        Console.WriteLine($"First Name : {person.FirstName}");
        Console.WriteLine($"Last Name  : {person.LastName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Primary Constructor parameters");
        Console.WriteLine("are commonly assigned");
        Console.WriteLine("to read-only properties.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates reading property values.
    /// </summary>
    private void ReadPropertyValues()
    {
        Console.WriteLine("Read Property Values");
        Console.WriteLine("--------------------------------------------------");

        Person person = new
        (
            10,
            "Sara",
            "Moradi"
        );

        Console.WriteLine(person.Id);
        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.LastName);
        Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Properties expose");
        Console.WriteLine("the values");
        Console.WriteLine("initialized");
        Console.WriteLine("during construction.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates a computed property.
    /// </summary>
    private void UseComputedProperty()
    {
        Console.WriteLine("Use Computed Property");
        Console.WriteLine("--------------------------------------------------");

        Person person = new
        (
            20,
            "Reza",
            "Karimi"
        );

        Console.WriteLine($"Full Name : {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A computed property");
        Console.WriteLine("combines");
        Console.WriteLine("other property values");
        Console.WriteLine("to produce");
        Console.WriteLine("new information.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating several objects.
    /// </summary>
    private void CreateMultipleObjects()
    {
        Console.WriteLine("Create Multiple Objects");
        Console.WriteLine("--------------------------------------------------");

        Person[] persons =
        [
            new Person(1,"Ali","Ahmadi"),
            new Person(2,"Sara","Moradi"),
            new Person(3,"Reza","Karimi"),
            new Person(4,"David","Brown")
        ];

        foreach (Person person in persons)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Each object");
        Console.WriteLine("stores");
        Console.WriteLine("its own");
        Console.WriteLine("property values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates comparing property values.
    /// </summary>
    private void ComparePropertyValues()
    {
        Console.WriteLine("Compare Property Values");
        Console.WriteLine("--------------------------------------------------");

        Person person1 = new Person(1, "Ali", "Ahmadi");

        Person person2 = new Person(2, "Sara", "Moradi");

        Console.WriteLine($"{person1.FullName} : {person1.Id}");
        Console.WriteLine($"{person2.FullName} : {person2.Id}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Each object's");
        Console.WriteLine("properties");
        Console.WriteLine("contain");
        Console.WriteLine("their own values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates accessing properties multiple times.
    /// </summary>
    private void AccessPropertiesMultipleTimes()
    {
        Console.WriteLine("Access Properties Multiple Times");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                100,
                "Michael",
                "Jordan"
            );

        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.FirstName);

        Console.WriteLine();

        Console.WriteLine(person.LastName);
        Console.WriteLine(person.LastName);

        Console.WriteLine();

        Console.WriteLine(person.FullName);
        Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Properties can be");
        Console.WriteLine("read multiple times");
        Console.WriteLine("without changing");
        Console.WriteLine("their values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates storing Person objects inside a List.
    /// </summary>
    private void StoreObjectsInsideList()
    {
        Console.WriteLine("Store Objects Inside List");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        Console.WriteLine($"Count : {persons.Count}");

        Console.WriteLine();

        foreach (Person person in persons)
            Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Properties behave");
        Console.WriteLine("the same");
        Console.WriteLine("whether objects");
        Console.WriteLine("are stored");
        Console.WriteLine("individually");
        Console.WriteLine("or inside collections.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates storing Person objects inside an array.
    /// </summary>
    private void StoreObjectsInsideArray()
    {
        Console.WriteLine("Store Objects Inside Array");
        Console.WriteLine("--------------------------------------------------");

        Person[] persons =
        [
            new Person(10, "David", "Brown"),
            new Person(20, "Emily", "Johnson"),
            new Person(30, "Jack", "Wilson")
        ];

        Console.WriteLine($"Length : {persons.Length}");

        Console.WriteLine();

        foreach (Person person in persons)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("do not change");
        Console.WriteLine("how arrays");
        Console.WriteLine("store objects.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates accessing properties by index.
    /// </summary>
    private void AccessPropertiesByIndex()
    {
        Console.WriteLine("Access Properties By Index");
        Console.WriteLine("--------------------------------------------------");

        Person[] persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        Console.WriteLine($"First  : {persons[0].FullName}");
        Console.WriteLine($"Second : {persons[1].FullName}");
        Console.WriteLine($"Third  : {persons[2].FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Properties remain");
        Console.WriteLine("accessible");
        Console.WriteLine("through array indexing.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates passing an object to another method.
    /// </summary>
    private void PassObjectToMethod()
    {
        Console.WriteLine("Pass Object To Method");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                500,
                "Thomas",
                "Anderson"
            );

        static void PrintPerson(Person person)
        {
            Console.WriteLine($"Id         : {person.Id}");
            Console.WriteLine($"First Name : {person.FirstName}");
            Console.WriteLine($"Last Name  : {person.LastName}");
            Console.WriteLine($"Full Name  : {person.FullName}");
            Console.WriteLine();
        }

        PrintPerson(person);

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Objects initialized");
        Console.WriteLine("using Primary Constructors");
        Console.WriteLine("can be passed");
        Console.WriteLine("to methods");
        Console.WriteLine("normally.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating objects from variables.
    /// </summary>
    private void CreateObjectFromVariables()
    {
        Console.WriteLine("Create Object From Variables");
        Console.WriteLine("--------------------------------------------------");

        int id = 1000;
        string firstName = "James";
        string lastName = "Smith";

        Person person =
            new Person
            (
                id,
                firstName,
                lastName
            );

        Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Constructor arguments");
        Console.WriteLine("can originate");
        Console.WriteLine("from variables");
        Console.WriteLine("instead of");
        Console.WriteLine("constant values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating objects from expressions.
    /// </summary>
    private void CreateObjectFromExpressions()
    {
        Console.WriteLine("Create Object From Expressions");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                100 + 200,
                "Ali".ToUpper(),
                "Ahmadi".ToLower()
            );

        Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Expressions");
        Console.WriteLine("are evaluated");
        Console.WriteLine("before");
        Console.WriteLine("being passed");
        Console.WriteLine("to the constructor.");
        Console.WriteLine();
    }
}