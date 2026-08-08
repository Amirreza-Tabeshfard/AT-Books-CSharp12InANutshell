using PrimaryConstructors.Models;

namespace PrimaryConstructors.Concepts;

internal class PrimaryConstructorAndMethods
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("============================================================");
        Console.WriteLine("06 - Primary Constructor And Methods");
        Console.WriteLine("============================================================");
        Console.WriteLine();

        CallToStringMethod();
        DisplayObjectInformation();
        PassObjectToMethod();
        CallMethodMultipleTimes();
        CreateObjectsInsideMethod();
        ProcessCollectionOfPersons();
        ReturnObjectFromMethod();
        CreateObjectUsingMethodParameters();
        CreateManyPersons();
        FindPersonById();
        CountPersons();
        OrderPersonsByFirstName();
        FilterPersons();
        SelectPersonNames();
    }

    private void PrintPerson(Person person)
    {
        Console.WriteLine($"Id         : {person.Id}");
        Console.WriteLine($"First Name : {person.FirstName}");
        Console.WriteLine($"Last Name  : {person.LastName}");
        Console.WriteLine($"Full Name  : {person.FullName}");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates calling ToString().
    /// </summary>
    private void CallToStringMethod()
    {
        Console.WriteLine("Call ToString Method");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1,
                "Ali",
                "Ahmadi"
            );

        Console.WriteLine(person.ToString());

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("do not change");
        Console.WriteLine("how instance methods");
        Console.WriteLine("behave.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates reading properties inside a method.
    /// </summary>
    private void DisplayObjectInformation()
    {
        Console.WriteLine("Display Object Information");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                10,
                "Sara",
                "Moradi"
            );

        Console.WriteLine($"Id         : {person.Id}");
        Console.WriteLine($"First Name : {person.FirstName}");
        Console.WriteLine($"Last Name  : {person.LastName}");
        Console.WriteLine($"Full Name  : {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Methods can");
        Console.WriteLine("access object");
        Console.WriteLine("properties normally.");
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
                20,
                "Reza",
                "Karimi"
            );

        PrintPerson(person);

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Objects created");
        Console.WriteLine("with Primary Constructors");
        Console.WriteLine("can be passed");
        Console.WriteLine("to any instance method.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates calling the same method repeatedly.
    /// </summary>
    private void CallMethodMultipleTimes()
    {
        Console.WriteLine("Call Method Multiple Times");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                30,
                "David",
                "Brown"
            );

        PrintPerson(person);
        PrintPerson(person);
        PrintPerson(person);

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Instance methods");
        Console.WriteLine("can be called");
        Console.WriteLine("multiple times");
        Console.WriteLine("on the same object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating objects inside a method.
    /// </summary>
    private void CreateObjectsInsideMethod()
    {
        Console.WriteLine("Create Objects Inside Method");
        Console.WriteLine("--------------------------------------------------");

        for (int i = 1; i <= 5; i++)
        {
            Person person =
                new Person
                (
                    i,
                    $"Person {i}",
                    "Demo"
                );

            Console.WriteLine(person);
        }

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Methods may create");
        Console.WriteLine("any number of objects");
        Console.WriteLine("using Primary Constructors.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates processing a collection of objects.
    /// </summary>
    private void ProcessCollectionOfPersons()
    {
        Console.WriteLine("Process Collection Of Persons");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1,"Ali","Ahmadi"),
            new Person(2,"Sara","Moradi"),
            new Person(3,"Reza","Karimi"),
            new Person(4,"David","Brown")
        ];

        foreach (Person person in persons)
            PrintPerson(person);

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Instance methods");
        Console.WriteLine("can process");
        Console.WriteLine("collections");
        Console.WriteLine("of objects");
        Console.WriteLine("without any");
        Console.WriteLine("special behavior.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates returning an object from a method.
    /// </summary>
    private void ReturnObjectFromMethod()
    {
        Console.WriteLine("Return Object From Method");
        Console.WriteLine("--------------------------------------------------");

        Person CreatePerson
            (
                int id,
                string firstName,
                string lastName
            )
        {
            return new Person
            (
                id,
                firstName,
                lastName
            );
        }

        Person person = CreatePerson
        (
            100,
            "Thomas",
            "Anderson"
        );

        Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Methods can");
        Console.WriteLine("create and return");
        Console.WriteLine("objects initialized");
        Console.WriteLine("with Primary Constructors.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a method parameter
    /// to create an object.
    /// </summary>
    private void CreateObjectUsingMethodParameters()
    {
        Console.WriteLine("Create Object Using Method Parameters");
        Console.WriteLine("--------------------------------------------------");

        void CreateAndDisplayPerson(int id,
                                    string firstName,
                                    string lastName)
        {
            Person person = new
            (
                id,
                firstName,
                lastName
            );

            Console.WriteLine(person);
            Console.WriteLine();
        }

        CreateAndDisplayPerson
        (
            200,
            "Jack",
            "Wilson"
        );

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Method parameters");
        Console.WriteLine("can be forwarded");
        Console.WriteLine("to a Primary Constructor.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating multiple objects
    /// inside a helper method.
    /// </summary>
    private void CreateManyPersons()
    {
        Console.WriteLine("Create Many Persons");
        Console.WriteLine("--------------------------------------------------");

        List<Person> GeneratePersons()
        {
            return
            [
                new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi"),
            new Person(4, "David", "Brown"),
            new Person(5, "Emily", "Johnson")
            ];
        }

        List<Person> persons = GeneratePersons();

        foreach (Person person in persons)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Methods can generate");
        Console.WriteLine("entire collections");
        Console.WriteLine("of objects.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates searching for an object.
    /// </summary>
    private void FindPersonById()
    {
        Console.WriteLine("Find Person By Id");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        Person? person =
            persons.FirstOrDefault(x => x.Id == 2);

        if (person is not null)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Methods can search");
        Console.WriteLine("through collections");
        Console.WriteLine("containing objects");
        Console.WriteLine("created with");
        Console.WriteLine("Primary Constructors.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates counting objects.
    /// </summary>
    private void CountPersons()
    {
        Console.WriteLine("Count Persons");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi"),
            new Person(4, "David", "Brown")
        ];

        Console.WriteLine($"Count : {persons.Count}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Collection methods");
        Console.WriteLine("work normally");
        Console.WriteLine("with objects");
        Console.WriteLine("created by");
        Console.WriteLine("Primary Constructors.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates ordering objects.
    /// </summary>
    private void OrderPersonsByFirstName()
    {
        Console.WriteLine("Order Persons By First Name");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(3, "Reza", "Karimi"),
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi")
        ];

        IEnumerable<Person> orderedPersons =
            persons.OrderBy(x => x.FirstName);

        foreach (Person person in orderedPersons)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("LINQ methods");
        Console.WriteLine("can operate");
        Console.WriteLine("on objects");
        Console.WriteLine("regardless of");
        Console.WriteLine("how they were created.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates filtering objects.
    /// </summary>
    private void FilterPersons()
    {
        Console.WriteLine("Filter Persons");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi"),
            new Person(4, "David", "Brown")
        ];

        IEnumerable<Person> filteredPersons =
            persons.Where(x => x.Id > 2);

        foreach (Person person in filteredPersons)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("LINQ filtering");
        Console.WriteLine("works exactly");
        Console.WriteLine("the same");
        Console.WriteLine("for Primary Constructor objects.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates projecting data.
    /// </summary>
    private void SelectPersonNames()
    {
        Console.WriteLine("Select Person Names");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        IEnumerable<string> names =
            persons.Select(x => x.FullName);

        foreach (string name in names)
            Console.WriteLine(name);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Projection methods");
        Console.WriteLine("can transform");
        Console.WriteLine("objects into");
        Console.WriteLine("other values.");
        Console.WriteLine();
    }
}