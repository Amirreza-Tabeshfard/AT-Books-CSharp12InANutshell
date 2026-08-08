using PrimaryConstructors.Models;

namespace PrimaryConstructors.Concepts;

internal class ReadonlyBehavior
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("============================================================");
        Console.WriteLine("07 - Readonly Behavior");
        Console.WriteLine("============================================================");
        Console.WriteLine();

        DemonstrateReadOnlyProperties();
        ReadPropertiesMultipleTimes();
        CompareTwoObjects();
        StoreObjectsInArray();
        StoreObjectsInList();
        PassObjectToMethod();
        VerifyValueStability();
        MultipleReferencesToSameObject();
        SeparateObjectsHaveSeparateState();
        ReadPropertyThroughParameter();
        UsePropertyInCondition();
        UsePropertiesInInterpolation();
        ReadPropertiesDuringIteration();
        SelectPropertyValues();
        FindPersonById();
        ComparePropertyValues();
        PassPropertyAsArgument();
        PassMultiplePropertiesAsArguments();
        UsePropertyInSwitch();
        UsePropertyInPattern();
        FilterUsingReadonlyProperty();
        OrderUsingReadonlyProperty();
        GroupUsingReadonlyProperty();
        CalculateFromProperties();
        ValidateBeforeProcessing();
        ConvertPersonToText();
        UsePropertyAsDictionaryKey();
        CheckPropertyValueExists();
        FindFirstMatchingPerson();
        CheckAllPersons();
        CountMatchingPersons();
        FindMinimumAndMaximumId();
        CalculatePropertySum();
        CalculatePropertyAverage();
        CreatePropertySnapshot();
        DemonstrateReferenceAssignment();
        ReadAfterMethodCall();
        ReadPropertyBeforeAndAfterMethod();
        CopyPropertyValueToVariable();
        ComparePropertyWithString();
        CombineMultipleProperties();
        ProjectNames();
        SortPersonsByName();
        ReversePersonSequence();
        CreateNameCollection();
        CheckDuplicateNames();
        SearchByFirstName();
        BuildValidationMessage();
        ReadFromAnotherMethod();
        ReturnPropertyValue();
        ReadPropertiesInsideLoop();
        BuildFormattedResult();
        CheckPropertyContent();
        ReadIdThroughMethod();
        ReadSeveralProperties();
        CalculateUsingProperty();
        EvaluateProperty();
        PassSameObjectToSeveralMethods();
        CreateSnapshot();
        EvaluateWithSwitch();
        ReadPropertyInsideCondition();
        ReadMultiplePropertiesInsideCondition();
        PassPropertyInsteadOfObject();
        ReturnCalculatedValue();
        CompareTwoPropertyValues();
        CopySeveralPropertyValues();
        FormatPropertyForOutput();
        ValidatePropertyValues();
    }

    /// <summary>
    /// Demonstrates reading readonly properties.
    /// </summary>
    private void DemonstrateReadOnlyProperties()
    {
        Console.WriteLine("Demonstrate ReadOnly Properties");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
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
        Console.WriteLine("Getter-only properties");
        Console.WriteLine("behave like");
        Console.WriteLine("read-only values");
        Console.WriteLine("after construction.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates repeated reads.
    /// </summary>
    private void ReadPropertiesMultipleTimes()
    {
        Console.WriteLine("Read Properties Multiple Times");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                2,
                "Sara",
                "Moradi"
            );

        Console.WriteLine(person.FullName);
        Console.WriteLine(person.FullName);
        Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Reading a property");
        Console.WriteLine("does not");
        Console.WriteLine("change");
        Console.WriteLine("its value.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates comparing readonly values.
    /// </summary>
    private void CompareTwoObjects()
    {
        Console.WriteLine("Compare Two Objects");
        Console.WriteLine("--------------------------------------------------");

        Person person1 =
            new Person(10, "Ali", "Ahmadi");

        Person person2 =
            new Person(20, "Sara", "Moradi");

        Console.WriteLine(person1.FullName);
        Console.WriteLine(person2.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Each object");
        Console.WriteLine("keeps");
        Console.WriteLine("its own");
        Console.WriteLine("property values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates storing readonly objects in an array.
    /// </summary>
    private void StoreObjectsInArray()
    {
        Console.WriteLine("Store Objects In Array");
        Console.WriteLine("--------------------------------------------------");

        Person[] persons =
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
        Console.WriteLine("Readonly properties");
        Console.WriteLine("can be accessed");
        Console.WriteLine("normally");
        Console.WriteLine("inside arrays.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates storing readonly objects in a list.
    /// </summary>
    private void StoreObjectsInList()
    {
        Console.WriteLine("Store Objects In List");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi"),
            new Person(4, "David", "Brown")
        ];

        foreach (Person person in persons)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Collections");
        Console.WriteLine("do not");
        Console.WriteLine("change");
        Console.WriteLine("readonly behavior.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates passing readonly objects to methods.
    /// </summary>
    private void PassObjectToMethod()
    {
        Console.WriteLine("Pass Object To Method");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                100,
                "David",
                "Brown"
            );

        void PrintPerson(Person person)
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
        Console.WriteLine("Readonly properties");
        Console.WriteLine("remain available");
        Console.WriteLine("inside");
        Console.WriteLine("other methods.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that reading a property does not modify its value.
    /// </summary>
    private void VerifyValueStability()
    {
        Console.WriteLine("Verify Value Stability");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                10,
                "Ali",
                "Ahmadi"
            );

        string firstRead = person.FullName;
        string secondRead = person.FullName;

        Console.WriteLine($"First Read  : {firstRead}");
        Console.WriteLine($"Second Read : {secondRead}");
        Console.WriteLine($"Same Value  : {firstRead == secondRead}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Reading a getter-only property");
        Console.WriteLine("does not modify");
        Console.WriteLine("the stored object state.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates accessing the same object
    /// through multiple references.
    /// </summary>
    private void MultipleReferencesToSameObject()
    {
        Console.WriteLine("Multiple References To Same Object");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                20,
                "Sara",
                "Moradi"
            );

        Person firstReference = person;
        Person secondReference = person;

        Console.WriteLine($"First Reference  : {firstReference.FullName}");
        Console.WriteLine($"Second Reference : {secondReference.FullName}");

        Console.WriteLine();

        Console.WriteLine($"Same Object : {ReferenceEquals(firstReference, secondReference)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Both variables");
        Console.WriteLine("refer to");
        Console.WriteLine("the same Person object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that separate constructor calls
    /// create separate objects.
    /// </summary>
    private void SeparateObjectsHaveSeparateState()
    {
        Console.WriteLine("Separate Objects Have Separate State");
        Console.WriteLine("--------------------------------------------------");

        Person firstPerson =
            new Person
            (
                30,
                "Reza",
                "Karimi"
            );

        Person secondPerson =
            new Person
            (
                30,
                "Reza",
                "Karimi"
            );

        Console.WriteLine($"First  : {firstPerson.FullName}");
        Console.WriteLine($"Second : {secondPerson.FullName}");

        Console.WriteLine();

        Console.WriteLine($"Same Object : {ReferenceEquals(firstPerson, secondPerson)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Identical constructor arguments");
        Console.WriteLine("do not mean");
        Console.WriteLine("that both variables");
        Console.WriteLine("refer to the same object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates reading a property
    /// through a method parameter.
    /// </summary>
    private void ReadPropertyThroughParameter()
    {
        Console.WriteLine("Read Property Through Parameter");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                40,
                "David",
                "Brown"
            );

        string ExtractName(Person person)
        {
            return person.FullName;
        }

        string name = ExtractName(person);

        Console.WriteLine($"Name : {name}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A method can receive");
        Console.WriteLine("a Person reference");
        Console.WriteLine("and read");
        Console.WriteLine("its properties.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a property
    /// in a conditional expression.
    /// </summary>
    private void UsePropertyInCondition()
    {
        Console.WriteLine("Use Property In Condition");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                50,
                "Emily",
                "Johnson"
            );

        if (!string.IsNullOrWhiteSpace(person.FullName))
            Console.WriteLine("The person has a valid full name.");
        else
            Console.WriteLine("The person does not have a valid full name.");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A read-only property");
        Console.WriteLine("can participate");
        Console.WriteLine("in normal");
        Console.WriteLine("conditional logic.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using properties in string interpolation.
    /// </summary>
    private void UsePropertiesInInterpolation()
    {
        Console.WriteLine("Use Properties In String Interpolation");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                60,
                "Jack",
                "Wilson"
            );

        string message = $"Person #{person.Id}: {person.FullName}";

        Console.WriteLine(message);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Getter-only properties");
        Console.WriteLine("can be embedded");
        Console.WriteLine("directly inside");
        Console.WriteLine("interpolated strings.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using properties in a collection iteration.
    /// </summary>
    private void ReadPropertiesDuringIteration()
    {
        Console.WriteLine("Read Properties During Iteration");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi"),
            new Person(4, "David", "Brown")
        ];

        foreach (Person person in persons)
            Console.WriteLine($"Id = {person.Id}, Name = {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Properties remain readable");
        Console.WriteLine("while iterating");
        Console.WriteLine("through a collection.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates selecting one property value
    /// from a collection of objects.
    /// </summary>
    private void SelectPropertyValues()
    {
        Console.WriteLine("Select Property Values");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        List<string> names =
            persons
                .Select(person => person.FullName)
                .ToList();

        foreach (string name in names)
            Console.WriteLine(name);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A property value");
        Console.WriteLine("can be projected");
        Console.WriteLine("from every object");
        Console.WriteLine("in a collection.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates searching objects
    /// using a property value.
    /// </summary>
    private void FindPersonById()
    {
        Console.WriteLine("Find Person By Id");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(10, "Ali", "Ahmadi"),
            new Person(20, "Sara", "Moradi"),
            new Person(30, "Reza", "Karimi")
        ];

        int requestedId = 20;

        Person? person = persons.FirstOrDefault(item => item.Id == requestedId);

        if (person is not null)
            Console.WriteLine($"Found : {person.FullName}");
        else
            Console.WriteLine("Person was not found.");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Read-only property values");
        Console.WriteLine("can be used");
        Console.WriteLine("as search criteria.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates checking whether
    /// two objects have matching property values.
    /// </summary>
    private void ComparePropertyValues()
    {
        Console.WriteLine("Compare Property Values");
        Console.WriteLine("--------------------------------------------------");

        Person first =
            new Person
            (
                100,
                "Ali",
                "Ahmadi"
            );

        Person second =
            new Person
            (
                100,
                "Ali",
                "Ahmadi"
            );

        bool sameId =
            first.Id == second.Id;

        bool sameName =
            first.FullName == second.FullName;

        Console.WriteLine($"Same Id   : {sameId}");
        Console.WriteLine($"Same Name : {sameName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Property values");
        Console.WriteLine("can be compared");
        Console.WriteLine("even when");
        Console.WriteLine("the objects themselves");
        Console.WriteLine("are different.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a property as a method argument.
    /// </summary>
    private void PassPropertyAsArgument()
    {
        Console.WriteLine("Pass Property As Argument");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                101,
                "Ali",
                "Ahmadi"
            );

        void PrintName(string name)
        {
            Console.WriteLine($"Name : {name}");
        }

        PrintName(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A property value");
        Console.WriteLine("can be passed");
        Console.WriteLine("directly to another method.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using multiple properties
    /// as method arguments.
    /// </summary>
    private void PassMultiplePropertiesAsArguments()
    {
        Console.WriteLine("Pass Multiple Properties As Arguments");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                102,
                "Sara",
                "Moradi"
            );

        void PrintPersonData(
                int id,
                string firstName,
                string lastName)
        {
            Console.WriteLine($"Id         : {id}");
            Console.WriteLine($"First Name : {firstName}");
            Console.WriteLine($"Last Name  : {lastName}");
        }

        PrintPersonData
        (
            person.Id,
            person.FirstName,
            person.LastName
        );

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Multiple property values");
        Console.WriteLine("can be passed");
        Console.WriteLine("to another method.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a property in a switch expression.
    /// </summary>
    private void UsePropertyInSwitch()
    {
        Console.WriteLine("Use Property In Switch");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                200,
                "Reza",
                "Karimi"
            );

        string category =
            person.Id switch
            {
                <= 0 => "Invalid",
                < 100 => "Standard",
                < 200 => "Advanced",
                _ => "Premium"
            };

        Console.WriteLine($"Person : {person.FullName}");
        Console.WriteLine($"Category : {category}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Read-only property values");
        Console.WriteLine("can be used");
        Console.WriteLine("inside switch expressions.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a property in a pattern.
    /// </summary>
    private void UsePropertyInPattern()
    {
        Console.WriteLine("Use Property In Pattern");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                300,
                "David",
                "Brown"
            );

        if (person is { Id: > 0 })
        {
            Console.WriteLine(
                $"{person.FullName} has a valid Id."
            );
        }

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Object properties");
        Console.WriteLine("can participate");
        Console.WriteLine("in property patterns.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using properties in LINQ filtering.
    /// </summary>
    private void FilterUsingReadonlyProperty()
    {
        Console.WriteLine("Filter Using ReadOnly Property");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(10, "Ali", "Ahmadi"),
            new Person(20, "Sara", "Moradi"),
            new Person(30, "Reza", "Karimi"),
            new Person(40, "David", "Brown")
        ];

        IEnumerable<Person> result =
            persons.Where(person => person.Id >= 20);

        foreach (Person person in result)
            Console.WriteLine($"{person.Id} - {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Getter-only properties");
        Console.WriteLine("can be used");
        Console.WriteLine("in LINQ predicates.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates ordering objects
    /// using a read-only property.
    /// </summary>
    private void OrderUsingReadonlyProperty()
    {
        Console.WriteLine("Order Using ReadOnly Property");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(30, "Reza", "Karimi"),
            new Person(10, "Ali", "Ahmadi"),
            new Person(20, "Sara", "Moradi")
        ];

        IEnumerable<Person> orderedPersons =
            persons.OrderBy(person => person.Id);

        foreach (Person person in orderedPersons)
            Console.WriteLine($"{person.Id} - {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A read-only property");
        Console.WriteLine("can be used");
        Console.WriteLine("as an ordering key.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates grouping objects
    /// using a property value.
    /// </summary>
    private void GroupUsingReadonlyProperty()
    {
        Console.WriteLine("Group Using ReadOnly Property");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(10, "Ali", "Ahmadi"),
            new Person(10, "Sara", "Moradi"),
            new Person(20, "Reza", "Karimi"),
            new Person(20, "David", "Brown")
        ];

        IEnumerable<IGrouping<int, Person>> groups =
            persons.GroupBy(person => person.Id);

        foreach (IGrouping<int, Person> group in groups)
        {
            Console.WriteLine($"Id : {group.Key}");

            foreach (Person person in group)
                Console.WriteLine($"    {person.FullName}");
        }

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Property values");
        Console.WriteLine("can be used");
        Console.WriteLine("as grouping keys.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates calculating information
    /// from object properties.
    /// </summary>
    private void CalculateFromProperties()
    {
        Console.WriteLine("Calculate From Properties");
        Console.WriteLine("--------------------------------------------------");

        Person first =
            new(10, "Ali", "Ahmadi");

        Person second =
            new(20, "Sara", "Moradi");

        Person third =
            new(30, "Reza", "Karimi");

        int total =
            first.Id +
            second.Id +
            third.Id;

        double average =
            total / 3.0;

        Console.WriteLine($"Total   : {total}");
        Console.WriteLine($"Average : {average}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Read-only property values");
        Console.WriteLine("can participate");
        Console.WriteLine("in calculations.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates checking a property
    /// before performing an operation.
    /// </summary>
    private void ValidateBeforeProcessing()
    {
        Console.WriteLine("Validate Before Processing");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new(
                500,
                "Emily",
                "Johnson"
            );

        void ProcessPerson(Person person)
        {
            Console.WriteLine($"Processing: {person.Id} - {person.FullName}");
        }

        if (person.Id > 0 && !string.IsNullOrWhiteSpace(person.FullName))
            ProcessPerson(person);
        else
            Console.WriteLine("Person data is invalid.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates converting a Person
    /// into a formatted string using its properties.
    /// </summary>
    private void ConvertPersonToText()
    {
        Console.WriteLine("Convert Person To Text");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                600,
                "Jack",
                "Wilson"
            );

        string ConvertToText(Person person)
        {
            return
                $"Person(Id={person.Id}, Name={person.FullName})";
        }

        string result = ConvertToText(person);

        Console.WriteLine(result);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Read-only properties");
        Console.WriteLine("can be used");
        Console.WriteLine("to build");
        Console.WriteLine("a new representation");
        Console.WriteLine("of an object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a read-only property
    /// as a dictionary key.
    /// </summary>
    private void UsePropertyAsDictionaryKey()
    {
        Console.WriteLine("Use Property As Dictionary Key");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(10, "Ali", "Ahmadi"),
            new Person(20, "Sara", "Moradi"),
            new Person(30, "Reza", "Karimi")
        ];

        Dictionary<int, Person> peopleById =
            persons.ToDictionary(person => person.Id);

        foreach (KeyValuePair<int, Person> item in peopleById)
            Console.WriteLine($"Key = {item.Key}, Name = {item.Value.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A property value");
        Console.WriteLine("can be used");
        Console.WriteLine("as a dictionary key.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates checking whether
    /// a property value exists in a collection.
    /// </summary>
    private void CheckPropertyValueExists()
    {
        Console.WriteLine("Check Property Value Exists");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        int searchedId = 2;

        bool exists =
            persons.Any(person => person.Id == searchedId);

        Console.WriteLine($"Id       : {searchedId}");
        Console.WriteLine($"Exists   : {exists}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A read-only property");
        Console.WriteLine("can be used");
        Console.WriteLine("to determine");
        Console.WriteLine("whether an object");
        Console.WriteLine("matches a condition.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates finding the first object
    /// that matches a property condition.
    /// </summary>
    private void FindFirstMatchingPerson()
    {
        Console.WriteLine("Find First Matching Person");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(10, "Ali", "Ahmadi"),
            new Person(20, "Sara", "Moradi"),
            new Person(30, "Reza", "Karimi"),
            new Person(40, "David", "Brown")
        ];

        Person? person =
            persons.FirstOrDefault(item => item.Id >= 30);

        if (person is not null)
            Console.WriteLine($"Found : {person.Id} - {person.FullName}");
        else
            Console.WriteLine("No matching person was found.");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Property values");
        Console.WriteLine("can be used");
        Console.WriteLine("when searching");
        Console.WriteLine("for objects.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates checking all objects
    /// through a property condition.
    /// </summary>
    private void CheckAllPersons()
    {
        Console.WriteLine("Check All Persons");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(10, "Ali", "Ahmadi"),
            new Person(20, "Sara", "Moradi"),
            new Person(30, "Reza", "Karimi")
        ];

        bool allValid =
            persons.All
            (
                person =>
                    person.Id > 0 &&
                    !string.IsNullOrWhiteSpace(person.FullName)
            );

        Console.WriteLine($"All Valid : {allValid}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The All operation");
        Console.WriteLine("can evaluate");
        Console.WriteLine("a condition");
        Console.WriteLine("against every object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates counting objects
    /// according to a property condition.
    /// </summary>
    private void CountMatchingPersons()
    {
        Console.WriteLine("Count Matching Persons");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(10, "Ali", "Ahmadi"),
            new Person(20, "Sara", "Moradi"),
            new Person(30, "Reza", "Karimi"),
            new Person(40, "David", "Brown")
        ];

        int count =
            persons.Count(person => person.Id >= 20);

        Console.WriteLine($"Matching Count : {count}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Property values");
        Console.WriteLine("can be used");
        Console.WriteLine("to count");
        Console.WriteLine("matching objects.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates obtaining minimum and maximum
    /// property values.
    /// </summary>
    private void FindMinimumAndMaximumId()
    {
        Console.WriteLine("Find Minimum And Maximum Id");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(40, "David", "Brown"),
            new Person(10, "Ali", "Ahmadi"),
            new Person(30, "Reza", "Karimi"),
            new Person(20, "Sara", "Moradi")
        ];

        int minimumId =
            persons.Min(person => person.Id);

        int maximumId =
            persons.Max(person => person.Id);

        Console.WriteLine($"Minimum Id : {minimumId}");
        Console.WriteLine($"Maximum Id : {maximumId}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Read-only properties");
        Console.WriteLine("can be used");
        Console.WriteLine("for aggregate operations.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates calculating the sum
    /// of a property across objects.
    /// </summary>
    private void CalculatePropertySum()
    {
        Console.WriteLine("Calculate Property Sum");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(10, "Ali", "Ahmadi"),
            new Person(20, "Sara", "Moradi"),
            new Person(30, "Reza", "Karimi")
        ];

        int sum =
            persons.Sum(person => person.Id);

        Console.WriteLine($"Sum of Ids : {sum}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A property");
        Console.WriteLine("can be selected");
        Console.WriteLine("and aggregated");
        Console.WriteLine("across a collection.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates calculating an average
    /// from a property.
    /// </summary>
    private void CalculatePropertyAverage()
    {
        Console.WriteLine("Calculate Property Average");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(10, "Ali", "Ahmadi"),
            new Person(20, "Sara", "Moradi"),
            new Person(30, "Reza", "Karimi")
        ];

        double average =
            persons.Average(person => person.Id);

        Console.WriteLine($"Average Id : {average}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The Average operation");
        Console.WriteLine("can work directly");
        Console.WriteLine("with a property value.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating a snapshot
    /// of property values.
    /// </summary>
    private void CreatePropertySnapshot()
    {
        Console.WriteLine("Create Property Snapshot");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                700,
                "Michael",
                "Jordan"
            );

        string snapshot =
            $"{person.Id}|{person.FirstName}|{person.LastName}|{person.FullName}";

        Console.WriteLine(snapshot);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Property values");
        Console.WriteLine("can be combined");
        Console.WriteLine("into a snapshot");
        Console.WriteLine("for later use.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that assigning a reference
    /// does not create another object.
    /// </summary>
    private void DemonstrateReferenceAssignment()
    {
        Console.WriteLine("Demonstrate Reference Assignment");
        Console.WriteLine("--------------------------------------------------");

        Person original =
            new Person
            (
                800,
                "James",
                "Smith"
            );

        Person reference = original;

        Console.WriteLine($"Original  : {original.FullName}");
        Console.WriteLine($"Reference : {reference.FullName}");

        Console.WriteLine();

        Console.WriteLine($"Same Object : {ReferenceEquals(original, reference)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Assigning a reference");
        Console.WriteLine("does not create");
        Console.WriteLine("a new Person object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates reading properties
    /// after passing an object through another method.
    /// </summary>
    private void ReadAfterMethodCall()
    {
        Console.WriteLine("Read After Method Call");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                900,
                "William",
                "Taylor"
            );

        void DisplayAndReturn(Person person)
        {
            Console.WriteLine($"Inside Method : {person.FullName}");
        }

        DisplayAndReturn(person);

        Console.WriteLine($"After Call : {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The object remains available");
        Console.WriteLine("after the method call");
        Console.WriteLine("and its properties");
        Console.WriteLine("can still be read.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates reading a property before and after
    /// passing the object to another method.
    /// </summary>
    private void ReadPropertyBeforeAndAfterMethod()
    {
        Console.WriteLine("Read Property Before And After Method");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1000,
                "Alexander",
                "Miller"
            );

        string before = person.FullName;

        void DisplayPersonName(Person person)
        {
            Console.WriteLine($"Current Name : {person.FullName}");
        }

        DisplayPersonName(person);

        string after = person.FullName;

        Console.WriteLine($"Before : {before}");
        Console.WriteLine($"After  : {after}");
        Console.WriteLine($"Same   : {before == after}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Reading a getter-only property");
        Console.WriteLine("before and after");
        Console.WriteLine("a method call");
        Console.WriteLine("produces the same value");
        Console.WriteLine("when the object state");
        Console.WriteLine("has not changed.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates assigning a property value
    /// to a local variable.
    /// </summary>
    private void CopyPropertyValueToVariable()
    {
        Console.WriteLine("Copy Property Value To Variable");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1100,
                "Robert",
                "Davis"
            );

        string name = person.FullName;

        Console.WriteLine($"Person Property : {person.FullName}");
        Console.WriteLine($"Local Variable  : {name}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The property value");
        Console.WriteLine("can be copied");
        Console.WriteLine("into a local variable.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a property value
    /// in string comparison.
    /// </summary>
    private void ComparePropertyWithString()
    {
        Console.WriteLine("Compare Property With String");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1200,
                "John",
                "Smith"
            );

        string expectedName = "John Smith";

        bool matches =
            person.FullName == expectedName;

        Console.WriteLine($"Actual   : {person.FullName}");
        Console.WriteLine($"Expected : {expectedName}");
        Console.WriteLine($"Matches  : {matches}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A property value");
        Console.WriteLine("can be compared");
        Console.WriteLine("with another value");
        Console.WriteLine("without modifying");
        Console.WriteLine("the object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using multiple getter-only properties
    /// in one expression.
    /// </summary>
    private void CombineMultipleProperties()
    {
        Console.WriteLine("Combine Multiple Properties");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1300,
                "Christopher",
                "Wilson"
            );

        string description =
            $"{person.Id}: {person.FirstName} {person.LastName}";

        Console.WriteLine(description);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Multiple properties");
        Console.WriteLine("can be combined");
        Console.WriteLine("without changing");
        Console.WriteLine("their original values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates selecting a property
    /// from a sequence of Person objects.
    /// </summary>
    private void ProjectNames()
    {
        Console.WriteLine("Project Names");
        Console.WriteLine("--------------------------------------------------");

        Person[] persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi"),
            new Person(4, "David", "Brown")
        ];

        IEnumerable<string> names =
            persons.Select(person => person.FullName);

        foreach (string name in names)
            Console.WriteLine(name);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A getter-only property");
        Console.WriteLine("can be projected");
        Console.WriteLine("into another sequence.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates sorting objects by a property.
    /// </summary>
    private void SortPersonsByName()
    {
        Console.WriteLine("Sort Persons By Name");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Reza", "Karimi"),
            new Person(2, "Ali", "Ahmadi"),
            new Person(3, "David", "Brown"),
            new Person(4, "Sara", "Moradi")
        ];

        IEnumerable<Person> sorted =
            persons.OrderBy(person => person.FullName);

        foreach (Person person in sorted)
            Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A read-only property");
        Console.WriteLine("can be used");
        Console.WriteLine("as a sorting key.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates reversing a collection
    /// without changing Person property values.
    /// </summary>
    private void ReversePersonSequence()
    {
        Console.WriteLine("Reverse Person Sequence");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        IEnumerable<Person> reversed =
            persons.AsEnumerable().Reverse();

        foreach (Person person in reversed)
            Console.WriteLine($"{person.Id} - {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Changing the order");
        Console.WriteLine("of references");
        Console.WriteLine("does not change");
        Console.WriteLine("the properties");
        Console.WriteLine("of the Person objects.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating a new collection
    /// from existing property values.
    /// </summary>
    private void CreateNameCollection()
    {
        Console.WriteLine("Create Name Collection");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        List<string> names =
            persons
                .Select(person => person.FullName)
                .ToList();

        Console.WriteLine($"Name Count : {names.Count}");

        foreach (string name in names)
            Console.WriteLine(name);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Property values");
        Console.WriteLine("can be extracted");
        Console.WriteLine("into a separate collection.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates checking for duplicate property values.
    /// </summary>
    private void CheckDuplicateNames()
    {
        Console.WriteLine("Check Duplicate Names");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Ali", "Ahmadi")
        ];

        int distinctNameCount =
            persons
                .Select(person => person.FullName)
                .Distinct()
                .Count();

        int totalNameCount =
            persons.Count;

        bool hasDuplicate =
            distinctNameCount != totalNameCount;

        Console.WriteLine($"Total Names    : {totalNameCount}");
        Console.WriteLine($"Distinct Names : {distinctNameCount}");
        Console.WriteLine($"Has Duplicate  : {hasDuplicate}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Read-only property values");
        Console.WriteLine("can be used");
        Console.WriteLine("to detect duplicate");
        Console.WriteLine("logical values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates checking whether
    /// a property starts with a specific value.
    /// </summary>
    private void SearchByFirstName()
    {
        Console.WriteLine("Search By First Name");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Alexander", "Miller"),
            new Person(4, "Reza", "Karimi")
        ];

        IEnumerable<Person> result =
            persons.Where
            (
                person =>
                    person.FirstName.StartsWith(
                        "A",
                        StringComparison.OrdinalIgnoreCase)
            );

        foreach (Person person in result)
            Console.WriteLine(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A getter-only property");
        Console.WriteLine("can be used");
        Console.WriteLine("inside string operations");
        Console.WriteLine("and search conditions.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a property
    /// as part of a validation message.
    /// </summary>
    private void BuildValidationMessage()
    {
        Console.WriteLine("Build Validation Message");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                0,
                "",
                ""
            );

        string message;

        if (person.Id <= 0)
            message =$"Invalid Id for person: {person.FullName}";
        else
            message = $"Person is valid: {person.FullName}";

        Console.WriteLine(message);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Read-only properties");
        Console.WriteLine("can be safely read");
        Console.WriteLine("while constructing");
        Console.WriteLine("validation messages.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that a getter-only property
    /// can be read from another method.
    /// </summary>
    private void ReadFromAnotherMethod()
    {
        Console.WriteLine("Read From Another Method");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1400,
                "Thomas",
                "Anderson"
            );

        string GetPersonName(Person person)
        {
            return person.FullName;
        }

        string name = GetPersonName(person);

        Console.WriteLine($"Name : {name}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A method can read");
        Console.WriteLine("a getter-only property");
        Console.WriteLine("through another method.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a getter-only property
    /// as a method return value.
    /// </summary>
    private void ReturnPropertyValue()
    {
        Console.WriteLine("Return Property Value");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1500,
                "Peter",
                "Parker"
            );

        string GetPersonFullName(Person person)
        {
            return person.FullName;
        }

        string result = GetPersonFullName(person);

        Console.WriteLine($"Result : {result}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A method can return");
        Console.WriteLine("the value of");
        Console.WriteLine("a getter-only property.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using read-only properties
    /// inside a loop.
    /// </summary>
    private void ReadPropertiesInsideLoop()
    {
        Console.WriteLine("Read Properties Inside Loop");
        Console.WriteLine("--------------------------------------------------");

        List<Person> persons =
        [
            new Person(1, "Ali", "Ahmadi"),
            new Person(2, "Sara", "Moradi"),
            new Person(3, "Reza", "Karimi")
        ];

        foreach (Person person in persons)
            Console.WriteLine($"#{person.Id} -> {person.FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Read-only properties");
        Console.WriteLine("can be read normally");
        Console.WriteLine("inside iteration blocks.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using property values
    /// to create a new formatted result.
    /// </summary>
    private void BuildFormattedResult()
    {
        Console.WriteLine("Build Formatted Result");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1600,
                "Bruce",
                "Wayne"
            );

        string result =
            $"[{person.Id}] {person.FullName}";

        Console.WriteLine(result);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Getter-only properties");
        Console.WriteLine("can be combined");
        Console.WriteLine("to create");
        Console.WriteLine("new calculated text.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates checking whether
    /// a property contains a specific value.
    /// </summary>
    private void CheckPropertyContent()
    {
        Console.WriteLine("Check Property Content");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1700,
                "Clark",
                "Kent"
            );

        bool containsKent =
            person.LastName.Contains(
                "Kent",
                StringComparison.OrdinalIgnoreCase);

        Console.WriteLine($"Full Name : {person.FullName}");
        Console.WriteLine($"Contains Kent : {containsKent}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A getter-only property");
        Console.WriteLine("can be used");
        Console.WriteLine("with normal string");
        Console.WriteLine("operations.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates reading the Id property
    /// through a separate instance method.
    /// </summary>
    private void ReadIdThroughMethod()
    {
        Console.WriteLine("Read Id Through Method");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1800,
                "George",
                "Miller"
            );

        int GetPersonId(Person person)
        {
            return person.Id;
        }

        int id = GetPersonId(person);

        Console.WriteLine($"Id : {id}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A getter-only property");
        Console.WriteLine("can be returned");
        Console.WriteLine("from another instance method.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates reading several properties
    /// from the same object.
    /// </summary>
    private void ReadSeveralProperties()
    {
        Console.WriteLine("Read Several Properties");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                1900,
                "Henry",
                "Taylor"
            );

        string BuildPersonInformation(
                int id,
                string firstName,
                string lastName)
        {
            return $"Id={id}, FirstName={firstName}, LastName={lastName}";
        }

        string information =
            BuildPersonInformation
            (
                person.Id,
                person.FirstName,
                person.LastName
            );

        Console.WriteLine(information);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Several read-only");
        Console.WriteLine("property values");
        Console.WriteLine("can be read");
        Console.WriteLine("from the same object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a property value
    /// in a mathematical calculation.
    /// </summary>
    private void CalculateUsingProperty()
    {
        Console.WriteLine("Calculate Using Property");
        Console.WriteLine("--------------------------------------------------");

        Person firstPerson =
            new Person
            (
                2000,
                "James",
                "Anderson"
            );

        Person secondPerson =
            new Person
            (
                3000,
                "Laura",
                "Wilson"
            );

        int difference =
            secondPerson.Id - firstPerson.Id;

        Console.WriteLine($"First Id  : {firstPerson.Id}");
        Console.WriteLine($"Second Id : {secondPerson.Id}");
        Console.WriteLine($"Difference: {difference}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Read-only properties");
        Console.WriteLine("can participate");
        Console.WriteLine("in normal calculations.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a property
    /// as part of a boolean expression.
    /// </summary>
    private void EvaluateProperty()
    {
        Console.WriteLine("Evaluate Property");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                2100,
                "Daniel",
                "White"
            );

        bool isPositive =
            person.Id > 0;

        bool hasName =
            !string.IsNullOrWhiteSpace(person.FullName);

        bool isValid =
            isPositive && hasName;

        Console.WriteLine($"Positive Id : {isPositive}");
        Console.WriteLine($"Has Name    : {hasName}");
        Console.WriteLine($"Is Valid    : {isValid}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Getter-only properties");
        Console.WriteLine("can participate");
        Console.WriteLine("in boolean expressions.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates passing a Person object
    /// to several methods without changing it.
    /// </summary>
    private void PassSameObjectToSeveralMethods()
    {
        Console.WriteLine("Pass Same Object To Several Methods");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                2200,
                "Matthew",
                "Clark"
            );

        void DisplayId(Person person)
        {
            Console.WriteLine($"Id         : {person.Id}");
        }

        void DisplayFirstName(Person person)
        {
            Console.WriteLine($"First Name : {person.FirstName}");
        }

        void DisplayLastName(Person person)
        {
            Console.WriteLine($"Last Name  : {person.LastName}");
        }

        void DisplayFullName(Person person)
        {
            Console.WriteLine($"Full Name  : {person.FullName}");
        }

        DisplayId(person);
        DisplayFirstName(person);
        DisplayLastName(person);
        DisplayFullName(person);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The same object");
        Console.WriteLine("can be passed");
        Console.WriteLine("to multiple methods.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating a read-only snapshot
    /// of an object's current property values.
    /// </summary>
    private void CreateSnapshot()
    {
        Console.WriteLine("Create Snapshot");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                2300,
                "Andrew",
                "Thomas"
            );

        string idSnapshot =
            person.Id.ToString();

        string nameSnapshot =
            person.FullName;

        Console.WriteLine($"Id Snapshot   : {idSnapshot}");
        Console.WriteLine($"Name Snapshot : {nameSnapshot}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Property values");
        Console.WriteLine("can be copied");
        Console.WriteLine("into independent");
        Console.WriteLine("local values.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a property
    /// in a switch statement.
    /// </summary>
    private void EvaluateWithSwitch()
    {
        Console.WriteLine("Evaluate With Switch");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                2400,
                "Edward",
                "Moore"
            );

        string result = person.Id switch
        {
            <= 0 => "Invalid",
            < 1000 => "Low",
            < 2000 => "Medium",
            _ => "High",
        };

        Console.WriteLine($"Id     : {person.Id}");
        Console.WriteLine($"Result : {result}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A read-only property");
        Console.WriteLine("can be used");
        Console.WriteLine("as the switch expression.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates reading a property inside a conditional block.
    /// </summary>
    private void ReadPropertyInsideCondition()
    {
        Console.WriteLine("Read Property Inside Condition");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                2500,
                "Oliver",
                "Martin"
            );

        if (person.Id > 0)
        {
            Console.WriteLine(
                $"Valid Person: {person.FullName}"
            );
        }

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A property value");
        Console.WriteLine("can directly participate");
        Console.WriteLine("in an if condition.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using several properties
    /// in a single conditional expression.
    /// </summary>
    private void ReadMultiplePropertiesInsideCondition()
    {
        Console.WriteLine("Read Multiple Properties Inside Condition");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                2600,
                "William",
                "Turner"
            );

        if (
            person.Id > 0 &&
            !string.IsNullOrWhiteSpace(person.FirstName) &&
            !string.IsNullOrWhiteSpace(person.LastName)
           )
        {
            Console.WriteLine(
                $"{person.FullName} is valid."
            );
        }
        else
        {
            Console.WriteLine(
                "Person information is invalid."
            );
        }

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Several getter-only properties");
        Console.WriteLine("can be evaluated");
        Console.WriteLine("in the same condition.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates passing a property value
    /// instead of the entire object.
    /// </summary>
    private void PassPropertyInsteadOfObject()
    {
        Console.WriteLine("Pass Property Instead Of Object");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                2700,
                "Daniel",
                "Harris"
            );

        void PrintValue(string value)
        {
            Console.WriteLine($"Value : {value}");
        }

        PrintValue(person.FullName);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Sometimes a method");
        Console.WriteLine("needs only");
        Console.WriteLine("a property value");
        Console.WriteLine("rather than the entire object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates returning a calculated value
    /// based on several properties.
    /// </summary>
    private void ReturnCalculatedValue()
    {
        Console.WriteLine("Return Calculated Value");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                2800,
                "Stephen",
                "King"
            );

        string CreatePersonSummary(Person person)
        {
            return
                $"Person {person.Id}: {person.FullName}";
        }

        string result =
            CreatePersonSummary(person);

        Console.WriteLine(result);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A method can calculate");
        Console.WriteLine("a new value");
        Console.WriteLine("from existing properties.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates comparing two property values.
    /// </summary>
    private void CompareTwoPropertyValues()
    {
        Console.WriteLine("Compare Two Property Values");
        Console.WriteLine("--------------------------------------------------");

        Person first =
            new Person
            (
                2900,
                "John",
                "Smith"
            );

        Person second =
            new Person
            (
                3000,
                "John",
                "Smith"
            );

        bool sameFirstName =
            first.FirstName == second.FirstName;

        bool sameLastName =
            first.LastName == second.LastName;

        bool sameFullName =
            first.FullName == second.FullName;

        Console.WriteLine(
            $"Same First Name : {sameFirstName}"
        );

        Console.WriteLine(
            $"Same Last Name  : {sameLastName}"
        );

        Console.WriteLine(
            $"Same Full Name  : {sameFullName}"
        );

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Properties from");
        Console.WriteLine("different objects");
        Console.WriteLine("can be compared");
        Console.WriteLine("independently.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates copying several property values
    /// into local variables.
    /// </summary>
    private void CopySeveralPropertyValues()
    {
        Console.WriteLine("Copy Several Property Values");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                3100,
                "George",
                "Wilson"
            );

        int id =
            person.Id;

        string firstName =
            person.FirstName;

        string lastName =
            person.LastName;

        string fullName =
            person.FullName;

        Console.WriteLine($"Id         : {id}");
        Console.WriteLine($"First Name : {firstName}");
        Console.WriteLine($"Last Name  : {lastName}");
        Console.WriteLine($"Full Name  : {fullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Property values");
        Console.WriteLine("can be copied");
        Console.WriteLine("into local variables");
        Console.WriteLine("for independent processing.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using a property
    /// in a formatted output method.
    /// </summary>
    private void FormatPropertyForOutput()
    {
        Console.WriteLine("Format Property For Output");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                3200,
                "Robert",
                "Johnson"
            );

        string FormatPersonName(string name)
        {
            return $"Name => {name}";
        }

        string output =
            FormatPersonName(person.FullName);

        Console.WriteLine(output);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A property value");
        Console.WriteLine("can be transformed");
        Console.WriteLine("before being displayed.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates using property values
    /// as arguments for validation.
    /// </summary>
    private void ValidatePropertyValues()
    {
        Console.WriteLine("Validate Property Values");
        Console.WriteLine("--------------------------------------------------");

        Person person =
            new Person
            (
                3300,
                "Emma",
                "Watson"
            );

        bool ValidatePerson(
                int id,
                string firstName,
                string lastName)
        {
            return
                id > 0 &&
                !string.IsNullOrWhiteSpace(firstName) &&
                !string.IsNullOrWhiteSpace(lastName);
        }

        bool valid =
            ValidatePerson
            (
                person.Id,
                person.FirstName,
                person.LastName
            );

        Console.WriteLine($"Valid : {valid}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Individual property values");
        Console.WriteLine("can be passed");
        Console.WriteLine("to validation methods.");
        Console.WriteLine();
    }
}