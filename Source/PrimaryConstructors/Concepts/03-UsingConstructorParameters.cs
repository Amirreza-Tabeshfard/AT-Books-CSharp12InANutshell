using PrimaryConstructors.Models;

namespace PrimaryConstructors.Concepts;

internal class UsingConstructorParameters
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("============================================================");
        Console.WriteLine("04 - Using Constructor Parameters");
        Console.WriteLine("============================================================");
        Console.WriteLine();

        InitializeProperties();
        UseParametersInComputedProperty();
        CreateMultipleObjects();
        CompareDifferentConstructorArguments();
        PrintObjectInformation();
        StorePersonsInArray();
        StorePersonsInList();
        AccessPropertiesMultipleTimes();
        CompareReferences();
        CompareDifferentObjects();
        CreatePersonsInsideLoop();
        PassVariablesToConstructor();
        ReadPropertiesMultipleTimes();
        PassObjectToMethod();
        CreateObjectFromVariables();
        CreateObjectUsingExpressions();
        CreateObjectsFromCollection();
        EveryConstructorCallCreatesNewObject();
        CreateObjectsFromUserData();
        CreatePersonArray();
        AccessArrayElements();
        IterateUsingForLoop();
        IterateUsingForeach();
        AssignReference();
        CallToString();
    }

    /// <summary>
    /// Demonstrates how constructor parameters
    /// initialize object properties.
    /// </summary>
    private void InitializeProperties()
    {
        Console.WriteLine("Initialize Properties");
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
        Console.WriteLine($"Full Name  : {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The constructor parameters");
        Console.WriteLine("are assigned");
        Console.WriteLine("to the object's properties.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using values that originated
    /// from constructor parameters.
    /// </summary>
    private void UseParametersInComputedProperty()
    {
        Console.WriteLine("Use Parameters In Computed Property");
        Console.WriteLine("--------------------------------------------------");

        Person person = new
        (
            2,
            "Sara",
            "Moradi"
        );

        Console.WriteLine($"Full Name : {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The FullName property");
        Console.WriteLine("uses values");
        Console.WriteLine("that originally came");
        Console.WriteLine("from the Primary Constructor.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating several objects
    /// using different constructor arguments.
    /// </summary>
    private void CreateMultipleObjects()
    {
        Console.WriteLine("Create Multiple Objects");
        Console.WriteLine("--------------------------------------------------");

        Person person1 = new(1, "Ali", "Ahmadi");
        Person person2 = new(2, "Sara", "Moradi");
        Person person3 = new(3, "Reza", "Karimi");

        Console.WriteLine(person1);
        Console.WriteLine(person2);
        Console.WriteLine(person3);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Every constructor call");
        Console.WriteLine("receives its own");
        Console.WriteLine("parameter values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that each object
    /// stores different constructor values.
    /// </summary>
    private void CompareDifferentConstructorArguments()
    {
        Console.WriteLine("Compare Different Constructor Arguments");
        Console.WriteLine("--------------------------------------------------");

        Person ali = new(10, "Ali", "Ahmadi");
        Person sara = new(20, "Sara", "Moradi");

        Console.WriteLine($"{ali.Id} - {ali.FullName}");
        Console.WriteLine($"{sara.Id} - {sara.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Each object");
        Console.WriteLine("stores");
        Console.WriteLine("its own");
        Console.WriteLine("constructor values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates printing object information.
    /// </summary>
    private void PrintObjectInformation()
    {
        Console.WriteLine("Print Object Information");
        Console.WriteLine("--------------------------------------------------");

        Person person = new
        (
            100,
            "David",
            "Brown"
        );

        Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Console.WriteLine");
        Console.WriteLine("calls ToString()");
        Console.WriteLine("to display");
        Console.WriteLine("the object's information.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates storing objects in an array.
    /// </summary>
    private void StorePersonsInArray()
    {
        Console.WriteLine("Store Persons In Array");
        Console.WriteLine("--------------------------------------------------");

        Person[] persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        foreach (Person person in persons)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Objects created by a Primary Constructor");
        Console.WriteLine("can be stored in arrays");
        Console.WriteLine("exactly like any other object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates storing objects in a List.
    /// </summary>
    private void StorePersonsInList()
    {
        Console.WriteLine("Store Persons In List");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(10, "David", "Brown"),
            new Person(20, "Jack", "Wilson"),
            new Person(30, "Emily", "Johnson")
        ];

        foreach (Person person in persons)
            Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("do not change");
        Console.WriteLine("how generic collections");
        Console.WriteLine("work.");
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
            new Person(100, "Michael", "Jordan");

        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.LastName);
        Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.LastName);
        Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Property values remain available");
        Console.WriteLine("for the lifetime");
        Console.WriteLine("of the object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates object identity.
    /// </summary>
    private void CompareReferences()
    {
        Console.WriteLine("Compare References");
        Console.WriteLine("--------------------------------------------------");

        Person person1 =
            new Person(1, "Ali", "Ahmadi");

        Person person2 =
            person1;

        Console.WriteLine($"Reference Equals : {ReferenceEquals(person1, person2)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Both variables");
        Console.WriteLine("refer to");
        Console.WriteLine("the same object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates two different objects.
    /// </summary>
    private void CompareDifferentObjects()
    {
        Console.WriteLine("Compare Different Objects");
        Console.WriteLine("--------------------------------------------------");

        Person person1 =
            new Person(1, "Ali", "Ahmadi");

        Person person2 =
            new Person(1, "Ali", "Ahmadi");

        Console.WriteLine($"Reference Equals : {ReferenceEquals(person1, person2)}");

        Console.WriteLine();

        Console.WriteLine(person1);
        Console.WriteLine(person2);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Even when");
        Console.WriteLine("constructor arguments");
        Console.WriteLine("are identical,");
        Console.WriteLine("two different objects");
        Console.WriteLine("are created.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating objects in a loop.
    /// </summary>
    private void CreatePersonsInsideLoop()
    {
        Console.WriteLine("Create Persons Inside Loop");
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
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("can be called");
        Console.WriteLine("inside loops");
        Console.WriteLine("without any limitation.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates passing constructor arguments from variables.
    /// </summary>
    private void PassVariablesToConstructor()
    {
        Console.WriteLine("Pass Variables To Constructor");
        Console.WriteLine("--------------------------------------------------");

        int id = 50;
        string firstName = "Thomas";
        string lastName = "Anderson";

        Person person =
            new Person(id, firstName, lastName);

        Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Constructor arguments");
        Console.WriteLine("do not have to");
        Console.WriteLine("be literal values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates reading the same property multiple times.
    /// </summary>
    private void ReadPropertiesMultipleTimes()
    {
        Console.WriteLine("Read Properties Multiple Times");
        Console.WriteLine("--------------------------------------------------");

        Person person = new
        (
            101,
            "Ali",
            "Ahmadi"
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
        Console.WriteLine("Once the object has been created,");
        Console.WriteLine("its properties can be");
        Console.WriteLine("accessed as many times");
        Console.WriteLine("as needed.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates passing an object to another method.
    /// </summary>
    private void PassObjectToMethod()
    {
        Console.WriteLine("Pass Object To Method");
        Console.WriteLine("--------------------------------------------------");

        Person person = new
        (
            200,
            "Sara",
            "Moradi"
        );

        void DisplayPerson(Person person)
        {
            Console.WriteLine($"Id         : {person.Id}");
            Console.WriteLine($"First Name : {person.FirstName}");
            Console.WriteLine($"Last Name  : {person.LastName}");
            Console.WriteLine($"Full Name  : {person.FullName}");
            Console.WriteLine();
        }

        DisplayPerson(person);

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Objects created");
        Console.WriteLine("with Primary Constructors");
        Console.WriteLine("can be passed");
        Console.WriteLine("to any method.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating objects from variables.
    /// </summary>
    private void CreateObjectFromVariables()
    {
        Console.WriteLine("Create Object From Variables");
        Console.WriteLine("--------------------------------------------------");

        int id = 300;
        string firstName = "Reza";
        string lastName = "Karimi";

        Person person = new
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
        Console.WriteLine("can come from");
        Console.WriteLine("variables,");
        Console.WriteLine("expressions,");
        Console.WriteLine("or method calls.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using expressions
    /// as constructor arguments.
    /// </summary>
    private void CreateObjectUsingExpressions()
    {
        Console.WriteLine("Create Object Using Expressions");
        Console.WriteLine("--------------------------------------------------");

        Person person = new
        (
            100 + 25,
            "Ali".ToUpper(),
            "Ahmadi".ToLower()
        );

        Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Constructor arguments");
        Console.WriteLine("may be expressions,");
        Console.WriteLine("not only constant values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates object initialization
    /// inside a foreach loop.
    /// </summary>
    private void CreateObjectsFromCollection()
    {
        Console.WriteLine("Create Objects From Collection");
        Console.WriteLine("--------------------------------------------------");

        string[] names =
        [
            "Ali",
            "Sara",
            "Reza",
            "David"
        ];

        int id = 1;

        foreach (string name in names)
        {
            Person person = new
            (
                id++,
                name,
                "Demo"
            );

            Console.WriteLine(person);
        }

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Objects can be");
        Console.WriteLine("created dynamically");
        Console.WriteLine("inside loops.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that every constructor call
    /// creates a new object.
    /// </summary>
    private void EveryConstructorCallCreatesNewObject()
    {
        Console.WriteLine("Every Constructor Call Creates New Object");
        Console.WriteLine("--------------------------------------------------");

        Person first = new(1, "Ali", "Ahmadi");
        Person second = new(1, "Ali", "Ahmadi");

        Console.WriteLine($"First  HashCode : {first.GetHashCode()}");
        Console.WriteLine($"Second HashCode : {second.GetHashCode()}");

        Console.WriteLine();

        Console.WriteLine($"Reference Equals : {ReferenceEquals(first, second)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Each constructor call");
        Console.WriteLine("allocates a new");
        Console.WriteLine("object in memory.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating objects from user-defined values.
    /// </summary>
    private void CreateObjectsFromUserData()
    {
        Console.WriteLine("Create Objects From User Data");
        Console.WriteLine("--------------------------------------------------");

        int id = 500;
        string firstName = "Thomas";
        string lastName = "Anderson";

        Person person = new
        (
            id,
            firstName,
            lastName
        );

        Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Constructor parameters");
        Console.WriteLine("may come from");
        Console.WriteLine("variables");
        Console.WriteLine("instead of");
        Console.WriteLine("hard-coded values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating an array of Person objects.
    /// </summary>
    private void CreatePersonArray()
    {
        Console.WriteLine("Create Person Array");
        Console.WriteLine("--------------------------------------------------");

        Person[] persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi"),
            new Person(4, "David", "Brown")
        ];

        Console.WriteLine($"Array Length : {persons.Length}");

        Console.WriteLine();

        foreach (Person person in persons)
            Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("work normally");
        Console.WriteLine("when creating");
        Console.WriteLine("arrays of objects.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates indexing an array.
    /// </summary>
    private void AccessArrayElements()
    {
        Console.WriteLine("Access Array Elements");
        Console.WriteLine("--------------------------------------------------");

        Person[] persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        Console.WriteLine($"First Person : {persons[0].FullName}");
        Console.WriteLine($"Second Person: {persons[1].FullName}");
        Console.WriteLine($"Third Person : {persons[2].FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Objects created");
        Console.WriteLine("with Primary Constructors");
        Console.WriteLine("can be accessed");
        Console.WriteLine("through indexes");
        Console.WriteLine("like any other array.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates iterating with a for loop.
    /// </summary>
    private void IterateUsingForLoop()
    {
        Console.WriteLine("Iterate Using For Loop");
        Console.WriteLine("--------------------------------------------------");

        Person[] persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        for (int i = 0; i < persons.Length; i++)
            Console.WriteLine(persons[i]);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The way");
        Console.WriteLine("objects are created");
        Console.WriteLine("does not affect");
        Console.WriteLine("array iteration.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates iterating with foreach.
    /// </summary>
    private void IterateUsingForeach()
    {
        Console.WriteLine("Iterate Using Foreach");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        foreach (Person person in persons)
            Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("foreach");
        Console.WriteLine("works exactly");
        Console.WriteLine("the same");
        Console.WriteLine("for objects");
        Console.WriteLine("created with");
        Console.WriteLine("Primary Constructors.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates assigning an object
    /// to another variable.
    /// </summary>
    private void AssignReference()
    {
        Console.WriteLine("Assign Reference");
        Console.WriteLine("--------------------------------------------------");

        Person original = new Person(1, "Ali", "Ahmadi");

        Person copy = original;

        Console.WriteLine(original);
        Console.WriteLine(copy);

        Console.WriteLine();

        Console.WriteLine($"Reference Equals : {ReferenceEquals(original, copy)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Only the reference");
        Console.WriteLine("is copied.");
        Console.WriteLine("A new object");
        Console.WriteLine("is not created.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using ToString().
    /// </summary>
    private void CallToString()
    {
        Console.WriteLine("Call ToString");
        Console.WriteLine("--------------------------------------------------");

        Person person = new Person(700, "Michael", "Jordan");

        Console.WriteLine(person.ToString());

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("ToString()");
        Console.WriteLine("works exactly");
        Console.WriteLine("the same");
        Console.WriteLine("regardless of");
        Console.WriteLine("how the object");
        Console.WriteLine("was initialized.");
        Console.WriteLine();
    }
}