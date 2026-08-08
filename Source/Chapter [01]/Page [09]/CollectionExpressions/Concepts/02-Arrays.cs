using CollectionExpressions.RealWorld;

namespace CollectionExpressions.Concepts;

internal class Arrays
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("============================================================");
        Console.WriteLine("02 - Arrays with Collection Expressions");
        Console.WriteLine("============================================================");
        Console.WriteLine();

        TraditionalArrayInitialization();
        CollectionExpressionInitialization();
        CompareTraditionalAndModernSyntax();
        InitializeIntegerArray();
        InitializeStringArray();
        InitializeDoubleArray();
        InitializeBooleanArray();
        InitializeCharacterArray();
        InitializeObjectArray();
        InitializeEmptyArray();
        AccessFirstElement();
        AccessLastElementUsingLength();
        AccessLastElementUsingIndexOperator();
        AccessSecondElementFromEnd();
        AccessThirdElementFromEnd();
        DisplayIndexes();
        CompareIndexAndCaretOperator();
        CommonIndexMistakes();
        IterateUsingForeach();
        IterateUsingForLoop();
        ModifyArrayElement();
        DisplayArrayInformation();
        CompareArrays();
        CopyArray();
        ReverseArray();
        SortArray();
        SearchArray();
        CheckArrayContainsValue();
        ResizeArray();
        VisualizeIndexOperator();
        CommonMistakes();
        WhenToUseArrays();
        Summary();
    }

    /// <summary>
    /// Shows how arrays were initialized before C# 12.
    /// </summary>
    private void TraditionalArrayInitialization()
    {
        Console.WriteLine("Traditional Array Initialization");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        {
            10,
            20,
            30,
            40,
            50
        };

        Console.WriteLine("Array Elements");

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();
        Console.WriteLine($"Length : {numbers.Length}");

        Console.WriteLine();
        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Before C# 12, arrays were initialized");
        Console.WriteLine("using curly braces { }.");
        Console.WriteLine("This syntax is still valid.");
        Console.WriteLine("Collection Expressions do not replace it.");
        Console.WriteLine();
    }

    /// <summary>
    /// Shows the new Collection Expression syntax.
    /// </summary>
    private void CollectionExpressionInitialization()
    {
        Console.WriteLine("Collection Expression Initialization");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Console.WriteLine("Array Elements");

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();
        Console.WriteLine($"Length : {numbers.Length}");

        Console.WriteLine();
        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions use square brackets [].");
        Console.WriteLine("The compiler still creates a normal array.");
        Console.WriteLine("Only the syntax becomes shorter.");
        Console.WriteLine();
    }

    /// <summary>
    /// Compares old syntax and new syntax.
    /// </summary>
    private void CompareTraditionalAndModernSyntax()
    {
        Console.WriteLine("Compare Traditional and Modern Syntax");
        Console.WriteLine("--------------------------------------------------");

        int[] oldStyle =
        {
            1,
            2,
            3
        };

        int[] newStyle =
        [
            1,
            2,
            3
        ];

        Console.WriteLine($"Old Length : {oldStyle.Length}");
        Console.WriteLine($"New Length : {newStyle.Length}");

        Console.WriteLine();

        Console.WriteLine($"Old First Item : {oldStyle[0]}");
        Console.WriteLine($"New First Item : {newStyle[0]}");

        Console.WriteLine();

        Console.WriteLine($"Reference Equals : {ReferenceEquals(oldStyle, newStyle)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The values are identical.");
        Console.WriteLine("The behavior is identical.");
        Console.WriteLine("Only the initialization syntax changed.");
        Console.WriteLine();
    }

    /// <summary>
    /// Initializes an integer array.
    /// </summary>
    private void InitializeIntegerArray()
    {
        Console.WriteLine("Initialize Integer Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            100,
            200,
            300,
            400,
            500
        ];

        Console.WriteLine("Printing Values");

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine($"Length : {numbers.Length}");

        Console.WriteLine($"First Item : {numbers[0]}");

        Console.WriteLine($"Last Item : {numbers[^1]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The compiler infers that every element");
        Console.WriteLine("must be compatible with int.");
        Console.WriteLine("numbers[^1] means the last element.");
        Console.WriteLine("The '^' operator counts from the end.");
        Console.WriteLine();
    }

    /// <summary>
    /// Initializes a string array using Collection Expressions.
    /// </summary>
    private void InitializeStringArray()
    {
        Console.WriteLine("Initialize String Array");
        Console.WriteLine("--------------------------------------------------");

        string[] countries =
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

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions work with string arrays.");
        Console.WriteLine("The target type is string[].");
        Console.WriteLine("Every element must therefore be a string.");
        Console.WriteLine();
    }

    /// <summary>
    /// Initializes a double array.
    /// </summary>
    private void InitializeDoubleArray()
    {
        Console.WriteLine("Initialize Double Array");
        Console.WriteLine("--------------------------------------------------");

        double[] prices =
        [
            10.5,
            20.75,
            30.99,
            40.25
        ];

        Console.WriteLine("Prices");

        foreach (double price in prices)
            Console.WriteLine(price);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions are not limited to integers.");
        Console.WriteLine("They work with any valid element type.");
        Console.WriteLine();
    }

    /// <summary>
    /// Initializes a boolean array.
    /// </summary>
    private void InitializeBooleanArray()
    {
        Console.WriteLine("Initialize Boolean Array");
        Console.WriteLine("--------------------------------------------------");

        bool[] values =
        [
            true,
            false,
            true,
            true
        ];

        Console.WriteLine("Boolean Values");

        foreach (bool value in values)
            Console.WriteLine(value);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The compiler creates a bool[] array.");
        Console.WriteLine("Every element must be either true or false.");
        Console.WriteLine();
    }

    /// <summary>
    /// Initializes a character array.
    /// </summary>
    private void InitializeCharacterArray()
    {
        Console.WriteLine("Initialize Character Array");
        Console.WriteLine("--------------------------------------------------");

        char[] letters =
        [
            'A',
            'B',
            'C',
            'D',
            'E'
        ];

        Console.WriteLine("Letters");

        foreach (char letter in letters)
            Console.Write($"{letter} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Characters are stored as char values.");
        Console.WriteLine("Collection Expressions support char[] just like any");
        Console.WriteLine("other array type.");
        Console.WriteLine();
    }

    /// <summary>
    /// Initializes an array of custom objects.
    /// </summary>
    private void InitializeObjectArray()
    {
        Console.WriteLine("Initialize Object Array");
        Console.WriteLine("--------------------------------------------------");

        Student[] students =
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
        Console.WriteLine("with arrays of custom objects.");
        Console.WriteLine("This is one of the most common");
        Console.WriteLine("real-world scenarios.");
        Console.WriteLine();
    }

    /// <summary>
    /// Creates an empty array.
    /// </summary>
    private void InitializeEmptyArray()
    {
        Console.WriteLine("Initialize Empty Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers = [];

        Console.WriteLine($"Length : {numbers.Length}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[] creates an empty array.");
        Console.WriteLine("The target type is determined");
        Console.WriteLine("from the variable declaration.");
        Console.WriteLine();
    }

    /// <summary>
    /// Accesses the first element in the array.
    /// </summary>
    private void AccessFirstElement()
    {
        Console.WriteLine("Access First Element");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Console.WriteLine($"numbers[0] = {numbers[0]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Array indexing always starts at zero.");
        Console.WriteLine("Index 0 always refers to the first element.");
        Console.WriteLine();
    }

    /// <summary>
    /// Accesses the last element using Length.
    /// </summary>
    private void AccessLastElementUsingLength()
    {
        Console.WriteLine("Access Last Element Using Length");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        int last = numbers[numbers.Length - 1];

        Console.WriteLine($"Last Element = {last}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Length returns the number of elements.");
        Console.WriteLine("The last index is always Length - 1.");
        Console.WriteLine();
    }

    /// <summary>
    /// Accesses the last element using the ^ operator.
    /// </summary>
    private void AccessLastElementUsingIndexOperator()
    {
        Console.WriteLine("Access Last Element Using ^");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Console.WriteLine($"numbers[^1] = {numbers[^1]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("^ means 'count from the end'.");
        Console.WriteLine("^1 means the last element.");
        Console.WriteLine("This is equivalent to numbers[numbers.Length - 1].");
        Console.WriteLine();
    }

    /// <summary>
    /// Accesses the second element from the end.
    /// </summary>
    private void AccessSecondElementFromEnd()
    {
        Console.WriteLine("Access Second Element From End");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Console.WriteLine($"numbers[^2] = {numbers[^2]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("^2 means the second element from the end.");
        Console.WriteLine("The result is 40.");
        Console.WriteLine();
    }

    /// <summary>
    /// Accesses the third element from the end.
    /// </summary>
    private void AccessThirdElementFromEnd()
    {
        Console.WriteLine("Access Third Element From End");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Console.WriteLine($"numbers[^3] = {numbers[^3]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("^3 means the third element from the end.");
        Console.WriteLine("The result is 30.");
        Console.WriteLine();
    }

    /// <summary>
    /// Displays every element together with its index.
    /// </summary>
    private void DisplayIndexes()
    {
        Console.WriteLine("Display Indexes");
        Console.WriteLine("--------------------------------------------------");

        string[] countries =
        [
            "Iran",
            "Germany",
            "Canada",
            "Japan"
        ];

        for (int i = 0; i < countries.Length; i++)
            Console.WriteLine($"Index {i} -> {countries[i]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Every array element has an index.");
        Console.WriteLine("The first index is always zero.");
        Console.WriteLine();
    }

    /// <summary>
    /// Compares normal indexing with the ^ operator.
    /// </summary>
    private void CompareIndexAndCaretOperator()
    {
        Console.WriteLine("Compare Index and Caret Operator");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Console.WriteLine($"numbers[4]                = {numbers[4]}");
        Console.WriteLine($"numbers[numbers.Length-1] = {numbers[numbers.Length - 1]}");
        Console.WriteLine($"numbers[^1]               = {numbers[^1]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("All three expressions return the same value.");
        Console.WriteLine("The ^ operator is simply cleaner and easier to read.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates common indexing mistakes.
    /// </summary>
    private void CommonIndexMistakes()
    {
        Console.WriteLine("Common Index Mistakes");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Correct");
        Console.WriteLine("numbers[0]");

        Console.WriteLine();

        Console.WriteLine("Correct");
        Console.WriteLine("numbers[^1]");

        Console.WriteLine();

        Console.WriteLine("Incorrect");
        Console.WriteLine("numbers[numbers.Length]");

        Console.WriteLine();

        Console.WriteLine("Incorrect");
        Console.WriteLine("numbers[^0]");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The largest valid index is Length - 1.");
        Console.WriteLine("^0 does not represent the last element.");
        Console.WriteLine("It points beyond the end of the array and");
        Console.WriteLine("will throw an IndexOutOfRangeException.");
        Console.WriteLine();
    }

    /// <summary>
    /// Iterates through an array using foreach.
    /// </summary>
    private void IterateUsingForeach()
    {
        Console.WriteLine("Iterate Using foreach");
        Console.WriteLine("--------------------------------------------------");

        string[] countries =
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
        Console.WriteLine("foreach is the easiest and safest");
        Console.WriteLine("way to iterate through an array.");
        Console.WriteLine("You don't need to manage indexes.");
        Console.WriteLine();
    }

    /// <summary>
    /// Iterates through an array using for.
    /// </summary>
    private void IterateUsingForLoop()
    {
        Console.WriteLine("Iterate Using for");
        Console.WriteLine("--------------------------------------------------");

        string[] countries =
        [
            "Iran",
            "Germany",
            "Canada",
            "Japan"
        ];

        for (int index = 0; index < countries.Length; index++)
            Console.WriteLine($"Index {index} : {countries[index]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Use a for loop when you need");
        Console.WriteLine("access to the array index.");
        Console.WriteLine();
    }

    /// <summary>
    /// Modifies an existing array element.
    /// </summary>
    private void ModifyArrayElement()
    {
        Console.WriteLine("Modify Array Element");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Console.WriteLine($"Before : {numbers[2]}");

        numbers[2] = 999;

        Console.WriteLine($"After  : {numbers[2]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions only create");
        Console.WriteLine("the array.");
        Console.WriteLine("Array elements can still be modified.");
        Console.WriteLine();
    }

    /// <summary>
    /// Displays basic information about an array.
    /// </summary>
    private void DisplayArrayInformation()
    {
        Console.WriteLine("Display Array Information");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            5,
            10,
            15,
            20,
            25
        ];

        Console.WriteLine($"Length        : {numbers.Length}");
        Console.WriteLine($"First Element : {numbers[0]}");
        Console.WriteLine($"Last Element  : {numbers[^1]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Length returns the number of elements.");
        Console.WriteLine("Indexes always start at zero.");
        Console.WriteLine();
    }

    /// <summary>
    /// Compares two arrays.
    /// </summary>
    private void CompareArrays()
    {
        Console.WriteLine("Compare Arrays");
        Console.WriteLine("--------------------------------------------------");

        int[] first =
        [
            1,
            2,
            3
        ];

        int[] second =
        [
            1,
            2,
            3
        ];

        Console.WriteLine($"ReferenceEquals : {ReferenceEquals(first, second)}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Even if two arrays contain");
        Console.WriteLine("the same values, they are");
        Console.WriteLine("different objects.");
        Console.WriteLine();
    }

    /// <summary>
    /// Copies one array into another.
    /// </summary>
    private void CopyArray()
    {
        Console.WriteLine("Copy Array");
        Console.WriteLine("--------------------------------------------------");

        int[] source =
        [
            10,
            20,
            30
        ];

        int[] destination = new int[source.Length];

        Array.Copy(source, destination, source.Length);

        Console.WriteLine("Destination");

        foreach (int number in destination)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Array.Copy creates");
        Console.WriteLine("a copy of the array elements.");
        Console.WriteLine();
    }

    /// <summary>
    /// Reverses an array.
    /// </summary>
    private void ReverseArray()
    {
        Console.WriteLine("Reverse Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Array.Reverse(numbers);

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Array.Reverse changes");
        Console.WriteLine("the order of the elements.");
        Console.WriteLine();
    }

    /// <summary>
    /// Sorts an array.
    /// </summary>
    private void SortArray()
    {
        Console.WriteLine("Sort Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            50,
            10,
            40,
            20,
            30
        ];

        Array.Sort(numbers);

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Array.Sort arranges");
        Console.WriteLine("elements in ascending order.");
        Console.WriteLine();
    }

    /// <summary>
    /// Searches for a value inside the array.
    /// </summary>
    private void SearchArray()
    {
        Console.WriteLine("Search Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        int index = Array.IndexOf(numbers, 30);

        Console.WriteLine($"Searching for 30...");
        Console.WriteLine($"Index : {index}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Array.IndexOf searches for a value.");
        Console.WriteLine("If the value exists, its index is returned.");
        Console.WriteLine("Otherwise, -1 is returned.");
        Console.WriteLine();
    }

    /// <summary>
    /// Checks whether an array contains a specific value.
    /// </summary>
    private void CheckArrayContainsValue()
    {
        Console.WriteLine("Check Array Contains Value");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        bool contains = numbers.Contains(40);

        Console.WriteLine($"Contains 40 : {contains}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Contains() returns true");
        Console.WriteLine("if the value exists.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates resizing an array.
    /// </summary>
    private void ResizeArray()
    {
        Console.WriteLine("Resize Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine($"Before Resize : {numbers.Length}");

        Array.Resize(ref numbers, 5);

        numbers[3] = 40;
        numbers[4] = 50;

        Console.WriteLine($"After Resize : {numbers.Length}");

        Console.WriteLine();

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Arrays have a fixed size.");
        Console.WriteLine("Array.Resize actually creates");
        Console.WriteLine("a new array behind the scenes.");
        Console.WriteLine();
    }

    /// <summary>
    /// Visualizes normal indexes and from-end indexes.
    /// </summary>
    private void VisualizeIndexOperator()
    {
        Console.WriteLine("Visualize Index Operator");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Console.WriteLine("Values");
        Console.WriteLine("10    20    30    40    50");

        Console.WriteLine();

        Console.WriteLine("Indexes");
        Console.WriteLine(" 0     1     2     3     4");

        Console.WriteLine();

        Console.WriteLine("From End");
        Console.WriteLine("^5    ^4    ^3    ^2    ^1");

        Console.WriteLine();

        Console.WriteLine($"numbers[0]  = {numbers[0]}");
        Console.WriteLine($"numbers[4]  = {numbers[4]}");
        Console.WriteLine($"numbers[^1] = {numbers[^1]}");
        Console.WriteLine($"numbers[^2] = {numbers[^2]}");
        Console.WriteLine($"numbers[^3] = {numbers[^3]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("^ counts from the end of the array.");
        Console.WriteLine("^1 is the last element.");
        Console.WriteLine("^2 is the second element from the end.");
        Console.WriteLine("^3 is the third element from the end.");
        Console.WriteLine();
    }

    /// <summary>
    /// Shows common mistakes when working with arrays.
    /// </summary>
    private void CommonMistakes()
    {
        Console.WriteLine("Common Mistakes");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Incorrect");
        Console.WriteLine("numbers[numbers.Length]");

        Console.WriteLine();

        Console.WriteLine("Correct");
        Console.WriteLine("numbers[numbers.Length - 1]");

        Console.WriteLine();

        Console.WriteLine("Correct");
        Console.WriteLine("numbers[^1]");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("The highest valid index");
        Console.WriteLine("is always Length - 1.");
        Console.WriteLine();
    }

    /// <summary>
    /// Explains when arrays are a good choice.
    /// </summary>
    private void WhenToUseArrays()
    {
        Console.WriteLine("When To Use Arrays");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Use arrays when:");
        Console.WriteLine();

        Console.WriteLine("✓ The size is fixed.");
        Console.WriteLine("✓ Maximum performance is required.");
        Console.WriteLine("✓ Memory usage should be minimal.");
        Console.WriteLine("✓ Fast indexed access is important.");

        Console.WriteLine();

        Console.WriteLine("Use List<T> instead when:");
        Console.WriteLine();

        Console.WriteLine("✓ Items are frequently added.");
        Console.WriteLine("✓ Items are frequently removed.");
        Console.WriteLine("✓ The size changes dynamically.");

        Console.WriteLine();
    }

    /// <summary>
    /// Summary of everything learned.
    /// </summary>
    private void Summary()
    {
        Console.WriteLine("Summary");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("In this lesson you learned:");

        Console.WriteLine();

        Console.WriteLine("✓ Traditional array initialization");
        Console.WriteLine("✓ Collection Expressions");
        Console.WriteLine("✓ Different array types");
        Console.WriteLine("✓ Empty arrays");
        Console.WriteLine("✓ Object arrays");
        Console.WriteLine("✓ Index operator (^)");
        Console.WriteLine("✓ foreach");
        Console.WriteLine("✓ for loop");
        Console.WriteLine("✓ Array.Copy");
        Console.WriteLine("✓ Array.Sort");
        Console.WriteLine("✓ Array.Reverse");
        Console.WriteLine("✓ Array.IndexOf");
        Console.WriteLine("✓ Contains()");
        Console.WriteLine("✓ Array.Resize()");
        Console.WriteLine("✓ Common mistakes");
        Console.WriteLine("✓ Best practices");

        Console.WriteLine();

        Console.WriteLine("Conclusion");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Collection Expressions provide");
        Console.WriteLine("a modern and concise syntax");
        Console.WriteLine("for creating arrays.");
        Console.WriteLine("They improve readability");
        Console.WriteLine("without changing array behavior.");
        Console.WriteLine();
    }
}