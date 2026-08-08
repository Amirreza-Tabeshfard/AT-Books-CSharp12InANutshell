using CollectionExpressions.RealWorld;

namespace CollectionExpressions.Concepts;

internal class Lists
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("============================================================");
        Console.WriteLine("03 - Collection Expressions With List<T>");
        Console.WriteLine("============================================================");
        Console.WriteLine();

        TraditionalListInitialization();
        CollectionExpressionInitialization();
        CompareTraditionalAndModernSyntax();
        InitializeIntegerList();
        InitializeStringList();
        InitializeObjectList();
        InitializeEmptyList();
        TargetTypingWithList();
        CollectionExpressionWithVariables();
        CollectionExpressionWithConstants();
        CollectionExpressionWithExpressions();
        AddItem();
        AddMultipleItems();
        InsertItem();
        RemoveItem();
        RemoveAtItem();
        ClearList();
        ContainsItem();
        IndexOfItem();
        SpreadOperatorWithList();
        MergeTwoLists();
        CombineMultipleCollections();
        MixValuesAndSpreadOperator();
        SpreadOperatorWithArray();
        SpreadOperatorWithMethodResult();
        NestedCollectionExpressions();
        CopyListUsingSpreadOperator();
        StudentListExample();
        ProductListExample();
        CollectionExpressionWithLinq();
        MixLiteralValuesAndLinq();
        ReadOnlyListExample();
        Summary();
    }

    /// <summary>
    /// Demonstrates the traditional way of creating a List before C# 12.
    /// </summary>
    private void TraditionalListInitialization()
    {
        Console.WriteLine("Traditional List Initialization");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers = new()
        {
            10,
            20,
            30,
            40,
            50
        };

        Console.WriteLine("List Elements");

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine($"Count : {numbers.Count}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Before C# 12, List<T> objects were");
        Console.WriteLine("typically initialized using object");
        Console.WriteLine("initializer syntax.");
        Console.WriteLine("This syntax is still valid today.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Collection Expressions with List<T>.
    /// </summary>
    private void CollectionExpressionInitialization()
    {
        Console.WriteLine("Collection Expression Initialization");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Console.WriteLine("List Elements");

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine($"Count : {numbers.Count}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions allow");
        Console.WriteLine("List<T> to be initialized");
        Console.WriteLine("using square brackets [].");
        Console.WriteLine("The compiler automatically");
        Console.WriteLine("creates the List<T> object.");
        Console.WriteLine();
    }

    /// <summary>
    /// Compares traditional syntax with Collection Expressions.
    /// </summary>
    private void CompareTraditionalAndModernSyntax()
    {
        Console.WriteLine("Compare Traditional and Modern Syntax");
        Console.WriteLine("--------------------------------------------------");

        List<int> oldStyle = new()
        {
            1,
            2,
            3
        };

        List<int> newStyle =
        [
            1,
            2,
            3
        ];

        Console.WriteLine($"Old Count : {oldStyle.Count}");
        Console.WriteLine($"New Count : {newStyle.Count}");

        Console.WriteLine();

        Console.WriteLine($"Old First Item : {oldStyle[0]}");
        Console.WriteLine($"New First Item : {newStyle[0]}");

        Console.WriteLine();

        Console.WriteLine($"Reference Equals : {ReferenceEquals(oldStyle, newStyle)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Both lists contain exactly");
        Console.WriteLine("the same values.");
        Console.WriteLine("Both behave the same way.");
        Console.WriteLine("Only the initialization");
        Console.WriteLine("syntax has changed.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates an integer List.
    /// </summary>
    private void InitializeIntegerList()
    {
        Console.WriteLine("Initialize Integer List");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            100,
            200,
            300,
            400,
            500
        ];

        Console.WriteLine("Values");

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine($"Count : {numbers.Count}");
        Console.WriteLine($"First : {numbers[0]}");
        Console.WriteLine($"Last  : {numbers[^1]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("List<T> supports indexing");
        Console.WriteLine("just like arrays.");
        Console.WriteLine("The '^' operator also works");
        Console.WriteLine("with List<T>.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates a string List.
    /// </summary>
    private void InitializeStringList()
    {
        Console.WriteLine("Initialize String List");
        Console.WriteLine("--------------------------------------------------");

        List<string> countries =
        [
            "Iran",
            "Germany",
            "Canada",
            "Japan",
            "Brazil"
        ];

        Console.WriteLine("Countries");

        foreach (string country in countries)
            Console.WriteLine(country);

        Console.WriteLine();

        Console.WriteLine($"Count : {countries.Count}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions work");
        Console.WriteLine("with any generic List<T>.");
        Console.WriteLine("The target type determines");
        Console.WriteLine("the element type.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates a List of custom objects.
    /// </summary>
    private void InitializeObjectList()
    {
        Console.WriteLine("Initialize Object List");
        Console.WriteLine("--------------------------------------------------");

        List<Student> students =
        [
            new Student(1, "Ali"),
            new Student(2, "Sara"),
            new Student(3, "Reza")
        ];

        foreach (Student student in students)
            Console.WriteLine(student);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions work perfectly");
        Console.WriteLine("with collections of custom objects.");
        Console.WriteLine("This is one of the most common");
        Console.WriteLine("enterprise scenarios.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates an empty List.
    /// </summary>
    private void InitializeEmptyList()
    {
        Console.WriteLine("Initialize Empty List");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers = [];

        Console.WriteLine($"Count : {numbers.Count}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("An empty Collection Expression");
        Console.WriteLine("creates an empty List<T>.");
        Console.WriteLine("No 'new()' is required.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing.
    /// </summary>
    private void TargetTypingWithList()
    {
        Console.WriteLine("Target Typing With List");
        Console.WriteLine("--------------------------------------------------");

        List<string> cities =
        [
            "Tehran",
            "Berlin",
            "Tokyo"
        ];

        foreach (string city in cities)
            Console.WriteLine(city);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The compiler already knows");
        Console.WriteLine("the target type is List<string>.");
        Console.WriteLine("Therefore every element");
        Console.WriteLine("must be a string.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Collection Expressions with variables.
    /// </summary>
    private void CollectionExpressionWithVariables()
    {
        Console.WriteLine("Collection Expression With Variables");
        Console.WriteLine("--------------------------------------------------");

        int first = 10;
        int second = 20;
        int third = 30;

        List<int> numbers =
        [
            first,
            second,
            third
        ];

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions");
        Console.WriteLine("can contain variables.");
        Console.WriteLine("The variable values");
        Console.WriteLine("are copied into the List.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Collection Expressions with constants.
    /// </summary>
    private void CollectionExpressionWithConstants()
    {
        Console.WriteLine("Collection Expression With Constants");
        Console.WriteLine("--------------------------------------------------");

        const int Min = 10;
        const int Max = 100;

        List<int> values =
        [
            Min,
            50,
            Max
        ];

        foreach (int value in values)
            Console.WriteLine(value);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Constants can also");
        Console.WriteLine("be placed inside");
        Console.WriteLine("Collection Expressions.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Collection Expressions with expressions.
    /// </summary>
    private void CollectionExpressionWithExpressions()
    {
        Console.WriteLine("Collection Expression With Expressions");
        Console.WriteLine("--------------------------------------------------");

        int x = 5;
        int y = 10;

        List<int> numbers =
        [
            x,
            y,
            x + y,
            x * y,
            y - x
        ];

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Each item may be");
        Console.WriteLine("a variable, a constant,");
        Console.WriteLine("or a complete expression.");
        Console.WriteLine("The expression is evaluated");
        Console.WriteLine("before being added to the List.");
        Console.WriteLine();
    }

    /// <summary>
    /// Adds a single item to a List.
    /// </summary>
    private void AddItem()
    {
        Console.WriteLine("Add Item");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine($"Count Before : {numbers.Count}");

        numbers.Add(40);

        Console.WriteLine($"Count After  : {numbers.Count}");

        Console.WriteLine();

        Console.WriteLine("Values");

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("List<T> is dynamic.");
        Console.WriteLine("Items can be added after creation.");
        Console.WriteLine("Arrays cannot do this.");
        Console.WriteLine();
    }

    /// <summary>
    /// Adds multiple items.
    /// </summary>
    private void AddMultipleItems()
    {
        Console.WriteLine("Add Multiple Items");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20
        ];

        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine($"Count : {numbers.Count}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Add() inserts one item");
        Console.WriteLine("at the end of the List.");
        Console.WriteLine();
    }

    /// <summary>
    /// Inserts an item at a specific index.
    /// </summary>
    private void InsertItem()
    {
        Console.WriteLine("Insert Item");
        Console.WriteLine("--------------------------------------------------");

        List<string> countries =
        [
            "Iran",
            "Canada",
            "Japan"
        ];

        countries.Insert(1, "Germany");

        foreach (string country in countries)
            Console.WriteLine(country);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Insert(index, value)");
        Console.WriteLine("adds an item at");
        Console.WriteLine("the specified position.");
        Console.WriteLine();
    }

    /// <summary>
    /// Removes an item by value.
    /// </summary>
    private void RemoveItem()
    {
        Console.WriteLine("Remove Item");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20,
            30,
            40
        ];

        numbers.Remove(20);

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Remove(value)");
        Console.WriteLine("removes the first");
        Console.WriteLine("matching value.");
        Console.WriteLine();
    }

    /// <summary>
    /// Removes an item by index.
    /// </summary>
    private void RemoveAtItem()
    {
        Console.WriteLine("Remove At");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20,
            30,
            40
        ];

        numbers.RemoveAt(2);

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("RemoveAt(index)");
        Console.WriteLine("removes the element");
        Console.WriteLine("at the specified index.");
        Console.WriteLine();
    }

    /// <summary>
    /// Clears all items.
    /// </summary>
    private void ClearList()
    {
        Console.WriteLine("Clear List");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine($"Before : {numbers.Count}");

        numbers.Clear();

        Console.WriteLine($"After  : {numbers.Count}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Clear()");
        Console.WriteLine("removes every item");
        Console.WriteLine("from the List.");
        Console.WriteLine();
    }

    /// <summary>
    /// Checks whether the List contains a value.
    /// </summary>
    private void ContainsItem()
    {
        Console.WriteLine("Contains");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20,
            30,
            40
        ];

        Console.WriteLine($"Contains 20 : {numbers.Contains(20)}");
        Console.WriteLine($"Contains 99 : {numbers.Contains(99)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Contains()");
        Console.WriteLine("returns true");
        Console.WriteLine("if the value exists.");
        Console.WriteLine();
    }

    /// <summary>
    /// Finds the index of an item.
    /// </summary>
    private void IndexOfItem()
    {
        Console.WriteLine("Index Of");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20,
            30,
            40
        ];

        Console.WriteLine($"Index Of 30 : {numbers.IndexOf(30)}");
        Console.WriteLine($"Index Of 99 : {numbers.IndexOf(99)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("IndexOf()");
        Console.WriteLine("returns -1");
        Console.WriteLine("when the value");
        Console.WriteLine("does not exist.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates the Spread Operator with List.
    /// </summary>
    private void SpreadOperatorWithList()
    {
        Console.WriteLine("Spread Operator With List");
        Console.WriteLine("--------------------------------------------------");

        List<int> source =
        [
            10,
            20,
            30
        ];

        List<int> destination =
        [
            ..source
        ];

        Console.WriteLine("Destination List");

        foreach (int number in destination)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The '..' operator copies every element");
        Console.WriteLine("from the source collection.");
        Console.WriteLine("It does not copy the collection itself.");
        Console.WriteLine();
    }

    /// <summary>
    /// Combines two Lists using the Spread Operator.
    /// </summary>
    private void MergeTwoLists()
    {
        Console.WriteLine("Merge Two Lists");
        Console.WriteLine("--------------------------------------------------");

        List<int> first =
        [
            10,
            20,
            30
        ];

        List<int> second =
        [
            40,
            50,
            60
        ];

        List<int> result =
        [
            ..first,
            ..second
        ];

        Console.WriteLine("Merged List");

        foreach (int number in result)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The Spread Operator expands");
        Console.WriteLine("each collection into");
        Console.WriteLine("the new List.");
        Console.WriteLine();
    }

    /// <summary>
    /// Combines multiple collections.
    /// </summary>
    private void CombineMultipleCollections()
    {
        Console.WriteLine("Combine Multiple Collections");
        Console.WriteLine("--------------------------------------------------");

        List<int> groupA =
        [
            1,
            2
        ];

        List<int> groupB =
        [
            3,
            4
        ];

        List<int> groupC =
        [
            5,
            6
        ];

        List<int> all =
        [
            ..groupA,
            ..groupB,
            ..groupC
        ];

        foreach (int number in all)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Any number of collections");
        Console.WriteLine("can be combined.");
        Console.WriteLine();
    }

    /// <summary>
    /// Mixes fixed values with Spread Operator.
    /// </summary>
    private void MixValuesAndSpreadOperator()
    {
        Console.WriteLine("Mix Values And Spread Operator");
        Console.WriteLine("--------------------------------------------------");

        List<int> middle =
        [
            20,
            30,
            40
        ];

        List<int> result =
        [
            10,
            ..middle,
            50,
            60
        ];

        foreach (int number in result)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions");
        Console.WriteLine("can mix literal values");
        Console.WriteLine("with Spread Operators.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Spread Operator with arrays.
    /// </summary>
    private void SpreadOperatorWithArray()
    {
        Console.WriteLine("Spread Operator With Array");
        Console.WriteLine("--------------------------------------------------");

        int[] array =
        [
            100,
            200,
            300
        ];

        List<int> numbers =
        [
            ..array
        ];

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The source collection");
        Console.WriteLine("does not have to be a List.");
        Console.WriteLine("Arrays also work.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Spread Operator with method results.
    /// </summary>
    private void SpreadOperatorWithMethodResult()
    {
        Console.WriteLine("Spread Operator With Method Result");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            ..GetNumbers()
        ];

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Any IEnumerable<T>");
        Console.WriteLine("can be expanded");
        Console.WriteLine("using '..'.");
        Console.WriteLine();
    }

    private IEnumerable<int> GetNumbers()
    {
        return
        [
            500,
            600,
            700
        ];
    }

    /// <summary>
    /// Demonstrates nested Collection Expressions.
    /// </summary>
    private void NestedCollectionExpressions()
    {
        Console.WriteLine("Nested Collection Expressions");
        Console.WriteLine("--------------------------------------------------");

        List<int> first =
        [
            1,
            2
        ];

        List<int> second =
        [
            3,
            4
        ];

        List<int> third =
        [
            5,
            6
        ];

        List<int> result =
        [
            0,
            ..first,
            ..second,
            ..third,
            7
        ];

        foreach (int number in result)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions");
        Console.WriteLine("can contain multiple");
        Console.WriteLine("Spread Operators.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates copying a List.
    /// </summary>
    private void CopyListUsingSpreadOperator()
    {
        Console.WriteLine("Copy List Using Spread Operator");
        Console.WriteLine("--------------------------------------------------");

        List<int> original =
        [
            10,
            20,
            30
        ];

        List<int> copy =
        [
            ..original
        ];

        original.Add(40);

        Console.WriteLine("Original");

        foreach (int item in original)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Copy");

        foreach (int item in copy)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The new List receives");
        Console.WriteLine("copies of the elements.");
        Console.WriteLine("The List objects are different.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating a List of students.
    /// </summary>
    private void StudentListExample()
    {
        Console.WriteLine("Student List Example");
        Console.WriteLine("--------------------------------------------------");

        List<Student> students =
        [
            new Student(1, "Ali", 21, "Computer Science"),
            new Student(2, "Sara", 22, "Software Engineering"),
            new Student(3, "Reza", 20, "Artificial Intelligence")
        ];

        Console.WriteLine("Students");

        foreach (Student student in students)
            Console.WriteLine(student);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions make");
        Console.WriteLine("object collection initialization");
        Console.WriteLine("much cleaner.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating a product catalog.
    /// </summary>
    private void ProductListExample()
    {
        Console.WriteLine("Product List Example");
        Console.WriteLine("--------------------------------------------------");

        List<string> products =
        [
            "Keyboard",
            "Mouse",
            "Monitor",
            "Laptop",
            "Headset"
        ];

        foreach (string product in products)
            Console.WriteLine(product);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("This is a common scenario");
        Console.WriteLine("for initializing lookup data.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating a list from LINQ.
    /// </summary>
    private void CollectionExpressionWithLinq()
    {
        Console.WriteLine("Collection Expression With LINQ");
        Console.WriteLine("--------------------------------------------------");

        IEnumerable<int> evenNumbers = Enumerable.Range(1, 20)
                                       .Where(number => number % 2 == 0);

        List<int> numbers =
        [
            ..evenNumbers
        ];

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The Spread Operator can expand");
        Console.WriteLine("any IEnumerable<T>.");
        Console.WriteLine("LINQ queries work perfectly.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates combining literals and LINQ.
    /// </summary>
    private void MixLiteralValuesAndLinq()
    {
        Console.WriteLine("Mix Literal Values And LINQ");
        Console.WriteLine("--------------------------------------------------");

        IEnumerable<int> even = Enumerable.Range(1, 10)
                                .Where(number => number % 2 == 0);

        List<int> result =
        [
            -1,
            0,
            ..even,
            100,
            200
        ];

        foreach (int item in result)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions can");
        Console.WriteLine("mix literal values");
        Console.WriteLine("and IEnumerable<T>.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating immutable data.
    /// </summary>
    private void ReadOnlyListExample()
    {
        Console.WriteLine("ReadOnly List Example");
        Console.WriteLine("--------------------------------------------------");

        IReadOnlyList<string> countries =
        [
            "Iran",
            "Germany",
            "Canada",
            "Japan"
        ];

        foreach (string country in countries)
            Console.WriteLine(country);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions");
        Console.WriteLine("also support interface");
        Console.WriteLine("target types.");
        Console.WriteLine();
    }

    /// <summary>
    /// Summary of everything learned.
    /// </summary>
    private void Summary()
    {
        Console.WriteLine("Summary");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("You learned:");

        Console.WriteLine();

        Console.WriteLine("✓ Traditional List initialization");
        Console.WriteLine("✓ Collection Expressions");
        Console.WriteLine("✓ Target Typing");
        Console.WriteLine("✓ Integer Lists");
        Console.WriteLine("✓ String Lists");
        Console.WriteLine("✓ Object Lists");
        Console.WriteLine("✓ Empty Lists");
        Console.WriteLine("✓ Variables");
        Console.WriteLine("✓ Constants");
        Console.WriteLine("✓ Expressions");
        Console.WriteLine("✓ Spread Operator");
        Console.WriteLine("✓ Merge Collections");
        Console.WriteLine("✓ IEnumerable<T>");
        Console.WriteLine("✓ LINQ");
        Console.WriteLine("✓ ReadOnlyList");
        Console.WriteLine("✓ Real World Examples");

        Console.WriteLine();

        Console.WriteLine("Conclusion");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions provide");
        Console.WriteLine("a concise and expressive way");
        Console.WriteLine("to initialize List<T> objects.");
        Console.WriteLine("The Spread Operator makes");
        Console.WriteLine("combining collections easy.");
        Console.WriteLine();
    }
}