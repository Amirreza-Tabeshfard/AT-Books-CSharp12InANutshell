using PrimaryConstructors.Models;

namespace PrimaryConstructors.Concepts;

internal class BasicClass
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("======================================================");
        Console.WriteLine("02 - Basic Primary Constructors");
        Console.WriteLine("======================================================");
        Console.WriteLine();

        CreateFirstPerson();
        CreateMultiplePersons();
        ReadProperties();
        CompareTraditionalAndPrimary();
        PrintObject();
        SingleParameter();
        MultipleParameters();
        DifferentDataTypes();
        StoreObjectsInArray();
        StoreObjectsInList();
        IterateArray();
        IterateList();
        CallObjectMethods();
        ObjectReference();
        CreateObjectsInsideLoop();
        ConstructorParametersCanBeDifferent();
        ConstructorParametersInitializeProperties();
        CreateManyObjects();
        CollectionExample();
        EachObjectHasItsOwnValues();
        CompareObjectReferences();
        CopyReference();
        PrimaryConstructorsDoNotChangeObjects();
    }

    /// <summary>
    /// Creates the first object using a Primary Constructor.
    /// </summary>
    private void CreateFirstPerson()
    {
        Console.WriteLine("Create First Person");
        Console.WriteLine("----------------------------------------");

        Person person = new
        (
            1,
            "Ali",
            "Ahmadi"
        );

        Console.WriteLine($"Id        : {person.Id}");
        Console.WriteLine($"FirstName : {person.FirstName}");
        Console.WriteLine($"LastName  : {person.LastName}");
        Console.WriteLine($"FullName  : {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("The constructor parameters");
        Console.WriteLine("are passed directly");
        Console.WriteLine("when creating the object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Creates multiple objects.
    /// </summary>
    private void CreateMultiplePersons()
    {
        Console.WriteLine("Create Multiple Persons");
        Console.WriteLine("----------------------------------------");

        Person person1 = new
        (
            1,
            "Ali",
            "Ahmadi"
        );

        Person person2 = new
        (
            2,
            "Sara",
            "Moradi"
        );

        Person person3 = new
        (
            3,
            "Reza",
            "Karimi"
        );

        Console.WriteLine(person1);
        Console.WriteLine(person2);
        Console.WriteLine(person3);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Each object stores");
        Console.WriteLine("its own values.");
        Console.WriteLine("Changing one object");
        Console.WriteLine("does not affect another.");
        Console.WriteLine();
    }

    /// <summary>
    /// Reads property values.
    /// </summary>
    private void ReadProperties()
    {
        Console.WriteLine("Read Properties");
        Console.WriteLine("----------------------------------------");

        Person person = new
        (
            10,
            "David",
            "Brown"
        );

        Console.WriteLine($"Id        : {person.Id}");
        Console.WriteLine($"FirstName : {person.FirstName}");
        Console.WriteLine($"LastName  : {person.LastName}");
        Console.WriteLine($"FullName  : {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Property access");
        Console.WriteLine("is exactly the same");
        Console.WriteLine("as any other class.");
        Console.WriteLine();
    }

    /// <summary>
    /// Compares traditional and primary constructors.
    /// </summary>
    private void CompareTraditionalAndPrimary()
    {
        Console.WriteLine("Compare Traditional Constructor");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Traditional");

        Console.WriteLine();

        Console.WriteLine("private readonly string _firstName;");
        Console.WriteLine("private readonly string _lastName;");
        Console.WriteLine();

        Console.WriteLine("public Person(string firstName,string lastName)");
        Console.WriteLine("{");
        Console.WriteLine("    _firstName = firstName;");
        Console.WriteLine("    _lastName = lastName;");
        Console.WriteLine("}");

        Console.WriteLine();

        Console.WriteLine("Primary Constructor");

        Console.WriteLine();

        Console.WriteLine("class Person(string firstName,string lastName)");
        Console.WriteLine("{");
        Console.WriteLine("    public string FirstName { get; } = firstName;");
        Console.WriteLine("    public string LastName { get; } = lastName;");
        Console.WriteLine("}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("remove repetitive");
        Console.WriteLine("constructor assignments.");
        Console.WriteLine();
    }

    /// <summary>
    /// Prints an object.
    /// </summary>
    private void PrintObject()
    {
        Console.WriteLine("Print Object");
        Console.WriteLine("----------------------------------------");

        Person person = new
        (
            5,
            "Michael",
            "Jordan"
        );

        Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Console.WriteLine(object)");
        Console.WriteLine("calls the object's");
        Console.WriteLine("ToString() method.");
        Console.WriteLine("If ToString() is overridden,");
        Console.WriteLine("that result is displayed.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates a Primary Constructor with a single parameter.
    /// </summary>
    private void SingleParameter()
    {
        Console.WriteLine("Single Parameter");
        Console.WriteLine("----------------------------------------");

        Person person = new
        (
            100,
            "John",
            "Smith"
        );

        Console.WriteLine($"Full Name : {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("A constructor may receive");
        Console.WriteLine("one or many parameters.");
        Console.WriteLine("The number of parameters");
        Console.WriteLine("depends on the requirements");
        Console.WriteLine("of the class.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates multiple constructor parameters.
    /// </summary>
    private void MultipleParameters()
    {
        Console.WriteLine("Multiple Parameters");
        Console.WriteLine("----------------------------------------");

        Student student = new
        (
            1,
            "Ali",
            "Ahmadi",
            21,
            "Computer Science"
        );

        Console.WriteLine(student);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("support multiple parameters");
        Console.WriteLine("just like traditional constructors.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates different parameter types.
    /// </summary>
    private void DifferentDataTypes()
    {
        Console.WriteLine("Different Data Types");
        Console.WriteLine("----------------------------------------");

        Product product = new
        (
            10,
            "Laptop",
            2500m
        );

        Console.WriteLine(product);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Constructor parameters");
        Console.WriteLine("can be any valid C# type.");
        Console.WriteLine("Examples include:");
        Console.WriteLine("int");
        Console.WriteLine("string");
        Console.WriteLine("decimal");
        Console.WriteLine("bool");
        Console.WriteLine("DateTime");
        Console.WriteLine("and custom classes.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates storing objects inside an array.
    /// </summary>
    private void StoreObjectsInArray()
    {
        Console.WriteLine("Store Objects In Array");
        Console.WriteLine("----------------------------------------");

        Person[] persons =
        [
            new Person(1,"Ali","Ahmadi"),
            new Person(2,"Sara","Moradi"),
            new Person(3,"Reza","Karimi")
        ];

        foreach (Person person in persons)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Objects created by");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("can be stored");
        Console.WriteLine("inside arrays");
        Console.WriteLine("exactly like");
        Console.WriteLine("any other object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates storing objects inside a List.
    /// </summary>
    private void StoreObjectsInList()
    {
        Console.WriteLine("Store Objects In List");
        Console.WriteLine("----------------------------------------");

        List<Person> persons =
        [
            new Person(1,"Ali","Ahmadi"),
            new Person(2,"Sara","Moradi"),
            new Person(3,"Reza","Karimi"),
            new Person(4,"David","Brown")
        ];

        foreach (Person person in persons)
        {
            Console.WriteLine(person);
        }

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("have no impact");
        Console.WriteLine("on collections.");
        Console.WriteLine("Objects behave");
        Console.WriteLine("exactly the same");
        Console.WriteLine("as objects created");
        Console.WriteLine("with traditional constructors.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates iterating through an array.
    /// </summary>
    private void IterateArray()
    {
        Console.WriteLine("Iterate Array");
        Console.WriteLine("----------------------------------------");

        Person[] persons =
        [
            new Person(1,"Ali","Ahmadi"),
            new Person(2,"Sara","Moradi"),
            new Person(3,"Reza","Karimi")
        ];

        foreach (Person person in persons)
        {
            Console.WriteLine($"Id : {person.Id}");
            Console.WriteLine($"Name : {person.FullName}");
            Console.WriteLine();
        }

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Iteration");
        Console.WriteLine("does not change");
        Console.WriteLine("when using");
        Console.WriteLine("Primary Constructors.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates iterating through a List.
    /// </summary>
    private void IterateList()
    {
        Console.WriteLine("Iterate List");
        Console.WriteLine("----------------------------------------");

        List<Person> persons =
        [
            new Person(10,"Jack","Smith"),
            new Person(20,"Emily","White"),
            new Person(30,"Robert","Taylor")
        ];

        foreach (Person person in persons)
            Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("List<T>");
        Console.WriteLine("works exactly");
        Console.WriteLine("the same");
        Console.WriteLine("regardless of");
        Console.WriteLine("how the object");
        Console.WriteLine("was constructed.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates calling methods on an object created
    /// with a Primary Constructor.
    /// </summary>
    private void CallObjectMethods()
    {
        Console.WriteLine("Call Object Methods");
        Console.WriteLine("----------------------------------------");

        Person person = new
        (
            100,
            "James",
            "Wilson"
        );

        Console.WriteLine(person.ToString());

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("only change");
        Console.WriteLine("how an object");
        Console.WriteLine("is initialized.");
        Console.WriteLine();
        Console.WriteLine("After construction");
        Console.WriteLine("the object behaves");
        Console.WriteLine("exactly like");
        Console.WriteLine("any normal C# object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates object references.
    /// </summary>
    private void ObjectReference()
    {
        Console.WriteLine("Object Reference");
        Console.WriteLine("----------------------------------------");

        Person person1 = new
        (
            1,
            "Ali",
            "Ahmadi"
        );

        Person person2 = person1;

        Console.WriteLine($"Person1 : {person1.FullName}");
        Console.WriteLine($"Person2 : {person2.FullName}");

        Console.WriteLine();

        Console.WriteLine($"Reference Equals : {ReferenceEquals(person1, person2)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("do not change");
        Console.WriteLine("reference behavior.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating objects inside a loop.
    /// </summary>
    private void CreateObjectsInsideLoop()
    {
        Console.WriteLine("Create Objects Inside Loop");
        Console.WriteLine("----------------------------------------");

        for (int i = 1; i <= 5; i++)
        {
            Person person = new
            (
                i,
                $"Person{i}",
                "Demo"
            );

            Console.WriteLine(person);
        }

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Objects can be");
        Console.WriteLine("created anywhere");
        Console.WriteLine("using Primary Constructors.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates constructor parameters with different values.
    /// </summary>
    private void ConstructorParametersCanBeDifferent()
    {
        Console.WriteLine("Constructor Parameters Can Be Different");
        Console.WriteLine("----------------------------------------");

        Person person1 = new(1, "Ali", "Ahmadi");
        Person person2 = new(2, "Sara", "Moradi");
        Person person3 = new(3, "David", "Brown");

        Console.WriteLine(person1);
        Console.WriteLine(person2);
        Console.WriteLine(person3);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Every constructor call");
        Console.WriteLine("can receive");
        Console.WriteLine("different values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that constructor parameters
    /// are copied into properties.
    /// </summary>
    private void ConstructorParametersInitializeProperties()
    {
        Console.WriteLine("Constructor Parameters Initialize Properties");
        Console.WriteLine("----------------------------------------");

        Person person = new
        (
            50,
            "Robert",
            "Taylor"
        );

        Console.WriteLine($"Id        : {person.Id}");
        Console.WriteLine($"FirstName : {person.FirstName}");
        Console.WriteLine($"LastName  : {person.LastName}");
        Console.WriteLine($"FullName  : {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Constructor parameters");
        Console.WriteLine("are typically assigned");
        Console.WriteLine("to properties");
        Console.WriteLine("or fields.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating many objects.
    /// </summary>
    private void CreateManyObjects()
    {
        Console.WriteLine("Create Many Objects");
        Console.WriteLine("----------------------------------------");

        List<Person> persons = [];

        for (int i = 1; i <= 10; i++)
        {
            persons.Add
            (
                new Person
                (
                    i,
                    $"Person{i}",
                    "Test"
                )
            );
        }

        foreach (Person person in persons)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("work efficiently");
        Console.WriteLine("even when");
        Console.WriteLine("creating many objects.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using object collections.
    /// </summary>
    private void CollectionExample()
    {
        Console.WriteLine("Collection Example");
        Console.WriteLine("----------------------------------------");

        List<Person> people =
        [
            new Person(1,"Ali","Ahmadi"),
            new Person(2,"Sara","Moradi"),
            new Person(3,"Reza","Karimi"),
            new Person(4,"David","Brown"),
            new Person(5,"Jack","Wilson")
        ];

        Console.WriteLine($"Total Persons : {people.Count}");

        Console.WriteLine();

        foreach (Person person in people)
            Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Objects created");
        Console.WriteLine("with Primary Constructors");
        Console.WriteLine("can be used");
        Console.WriteLine("inside every");
        Console.WriteLine(".NET collection.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that constructor parameters
    /// belong to each object separately.
    /// </summary>
    private void EachObjectHasItsOwnValues()
    {
        Console.WriteLine("Each Object Has Its Own Values");
        Console.WriteLine("--------------------------------------------------");

        Person ali = new
        (
            1,
            "Ali",
            "Ahmadi"
        );

        Person sara = new
        (
            2,
            "Sara",
            "Moradi"
        );

        Console.WriteLine(ali.FullName);
        Console.WriteLine(sara.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Every object");
        Console.WriteLine("stores");
        Console.WriteLine("its own");
        Console.WriteLine("property values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates object identity.
    /// </summary>
    private void CompareObjectReferences()
    {
        Console.WriteLine("Compare Object References");
        Console.WriteLine("--------------------------------------------------");

        Person person1 = new
        (
            1,
            "Ali",
            "Ahmadi"
        );

        Person person2 = new
        (
            1,
            "Ali",
            "Ahmadi"
        );

        Console.WriteLine($"Reference Equals : {ReferenceEquals(person1, person2)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Even if");
        Console.WriteLine("two objects");
        Console.WriteLine("contain");
        Console.WriteLine("exactly");
        Console.WriteLine("the same values,");
        Console.WriteLine("they are");
        Console.WriteLine("different objects");
        Console.WriteLine("in memory.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates assigning one reference to another.
    /// </summary>
    private void CopyReference()
    {
        Console.WriteLine("Copy Reference");
        Console.WriteLine("--------------------------------------------------");

        Person person1 = new
        (
            10,
            "John",
            "Smith"
        );

        Person person2 = person1;

        Console.WriteLine($"Reference Equals : {ReferenceEquals(person1, person2)}");

        Console.WriteLine(person1);
        Console.WriteLine(person2);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Both variables");
        Console.WriteLine("point to");
        Console.WriteLine("the same");
        Console.WriteLine("object instance.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that Primary Constructors
    /// do not change object behavior.
    /// </summary>
    private void PrimaryConstructorsDoNotChangeObjects()
    {
        Console.WriteLine("Primary Constructors Do Not Change Objects");
        Console.WriteLine("--------------------------------------------------");

        Person person = new
        (
            100,
            "Michael",
            "Jordan"
        );

        Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Primary Constructors");
        Console.WriteLine("only simplify");
        Console.WriteLine("object initialization.");
        Console.WriteLine();
        Console.WriteLine("After the object");
        Console.WriteLine("has been created,");
        Console.WriteLine("everything behaves");
        Console.WriteLine("exactly");
        Console.WriteLine("like every");
        Console.WriteLine("other C# class.");
        Console.WriteLine();
    }
}