namespace CollectionExpressions.Concepts;

internal class Spans
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("============================================================");
        Console.WriteLine("04 - Collection Expressions With Span<T>");
        Console.WriteLine("============================================================");
        Console.WriteLine();

        WhatIsSpan();
        TraditionalSpanInitialization();
        CollectionExpressionInitialization();
        CompareTraditionalAndCollectionExpression();
        TargetTypingWithSpan();
        InitializeIntegerSpan();
        InitializeStringSpan();
        InitializeCharSpan();
        InitializeEmptySpan();
        AccessFirstElement();
        AccessLastElement();
        AccessByIndex();
        SpanPointsToExistingMemory();
        SpanDoesNotCopyData();
        ModifyElementThroughSpan();
        CreateSpanFromArray();
        CreateSpanUsingStackalloc();
    }

    /// <summary>
    /// Introduces the concept of Span<T>.
    /// </summary>
    private void WhatIsSpan()
    {
        Console.WriteLine("What Is Span<T>");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine($"Length : {numbers.Length}");

        Console.WriteLine();

        Console.WriteLine("Values");

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Memory Visualization");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("+----+----+----+");
        Console.WriteLine("| 10 | 20 | 30 |");
        Console.WriteLine("+----+----+----+");
        Console.WriteLine("   ^");
        Console.WriteLine(" Span points here.");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Span<T> does NOT own memory.");
        Console.WriteLine("It only provides a window");
        Console.WriteLine("over existing memory.");
        Console.WriteLine("No data is copied.");
        Console.WriteLine();
    }

    /// <summary>
    /// Traditional syntax before Collection Expressions.
    /// </summary>
    private void TraditionalSpanInitialization()
    {
        Console.WriteLine("Traditional Span Initialization");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers = stackalloc int[]
        {
            10,
            20,
            30,
            40
        };

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Before C# 12");
        Console.WriteLine("creating a Span usually");
        Console.WriteLine("required stackalloc.");
        Console.WriteLine();
    }

    /// <summary>
    /// Collection Expressions with Span.
    /// </summary>
    private void CollectionExpressionInitialization()
    {
        Console.WriteLine("Collection Expression Initialization");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers =
        [
            10,
            20,
            30,
            40
        ];

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Collection Expressions");
        Console.WriteLine("can initialize Span<T>");
        Console.WriteLine("without writing");
        Console.WriteLine("stackalloc manually.");
        Console.WriteLine();
    }

    /// <summary>
    /// Compares old syntax with new syntax.
    /// </summary>
    private void CompareTraditionalAndCollectionExpression()
    {
        Console.WriteLine("Compare Traditional And Collection Expression");
        Console.WriteLine("--------------------------------------------------");

        Span<int> oldStyle = stackalloc int[]
        {
            1,
            2,
            3
        };

        Span<int> newStyle =
        [
            1,
            2,
            3
        ];

        Console.WriteLine("Old Style");

        foreach (int item in oldStyle)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("New Style");

        foreach (int item in newStyle)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Both Spans contain");
        Console.WriteLine("exactly the same values.");
        Console.WriteLine("Collection Expressions");
        Console.WriteLine("simply make the code");
        Console.WriteLine("shorter and easier to read.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates target typing.
    /// </summary>
    private void TargetTypingWithSpan()
    {
        Console.WriteLine("Target Typing With Span");
        Console.WriteLine("--------------------------------------------------");

        Span<string> cities =
        [
            "Tehran",
            "Berlin",
            "Tokyo"
        ];

        foreach (string city in cities)
            Console.WriteLine(city);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The compiler already knows");
        Console.WriteLine("that the target type");
        Console.WriteLine("is Span<string>.");
        Console.WriteLine("Each element therefore");
        Console.WriteLine("must be a string.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates an integer Span.
    /// </summary>
    private void InitializeIntegerSpan()
    {
        Console.WriteLine("Initialize Integer Span");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Console.WriteLine($"Length : {numbers.Length}");
        Console.WriteLine();

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Memory Visualization");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("+----+----+----+----+----+");
        Console.WriteLine("|10  |20  |30  |40  |50  |");
        Console.WriteLine("+----+----+----+----+----+");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Span<int> behaves like");
        Console.WriteLine("a lightweight window");
        Console.WriteLine("over contiguous memory.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates a string Span.
    /// </summary>
    private void InitializeStringSpan()
    {
        Console.WriteLine("Initialize String Span");
        Console.WriteLine("--------------------------------------------------");

        Span<string> countries =
        [
            "Iran",
            "Germany",
            "Canada",
            "Japan"
        ];

        foreach (string country in countries)
            Console.WriteLine(country);

        Console.WriteLine();

        Console.WriteLine($"Length : {countries.Length}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Span<T> supports");
        Console.WriteLine("reference types as well.");
        Console.WriteLine("The elements remain");
        Console.WriteLine("string references.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates a character Span.
    /// </summary>
    private void InitializeCharSpan()
    {
        Console.WriteLine("Initialize Char Span");
        Console.WriteLine("--------------------------------------------------");

        Span<char> letters =
        [
            'A',
            'B',
            'C',
            'D',
            'E'
        ];

        foreach (char letter in letters)
            Console.Write($"{letter} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Span<char>");
        Console.WriteLine("is frequently used");
        Console.WriteLine("for text processing.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates an empty Span.
    /// </summary>
    private void InitializeEmptySpan()
    {
        Console.WriteLine("Initialize Empty Span");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers = [];

        Console.WriteLine($"Length : {numbers.Length}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Collection Expressions");
        Console.WriteLine("can create");
        Console.WriteLine("an empty Span.");
        Console.WriteLine();
    }

    /// <summary>
    /// Accesses the first element.
    /// </summary>
    private void AccessFirstElement()
    {
        Console.WriteLine("Access First Element");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers =
        [
            10,
            20,
            30,
            40
        ];

        Console.WriteLine($"First : {numbers[0]}");

        Console.WriteLine();

        Console.WriteLine("Memory Visualization");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Index : 0   1   2   3");
        Console.WriteLine("Value :10  20  30  40");
        Console.WriteLine("       ^");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Index zero");
        Console.WriteLine("always refers");
        Console.WriteLine("to the first element.");
        Console.WriteLine();
    }

    /// <summary>
    /// Accesses the last element.
    /// </summary>
    private void AccessLastElement()
    {
        Console.WriteLine("Access Last Element");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers =
        [
            10,
            20,
            30,
            40
        ];

        Console.WriteLine($"Last : {numbers[^1]}");

        Console.WriteLine();

        Console.WriteLine("Memory Visualization");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Index : 0   1   2   3");
        Console.WriteLine("Value :10  20  30  40");
        Console.WriteLine("                   ^");
        Console.WriteLine("                  ^1");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("^1 means");
        Console.WriteLine("the last element.");
        Console.WriteLine("The '^' operator");
        Console.WriteLine("counts from the end.");
        Console.WriteLine();
    }

    /// <summary>
    /// Accesses an element by index.
    /// </summary>
    private void AccessByIndex()
    {
        Console.WriteLine("Access By Index");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers =
        [
            100,
            200,
            300,
            400,
            500
        ];

        Console.WriteLine($"numbers[2] = {numbers[2]}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Span<T>");
        Console.WriteLine("supports indexing");
        Console.WriteLine("exactly like arrays.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that Span points to existing memory.
    /// </summary>
    private void SpanPointsToExistingMemory()
    {
        Console.WriteLine("Span Points To Existing Memory");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40,
            50
        ];

        Span<int> span = numbers;

        Console.WriteLine("Array Before");

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        span[1] = 999;

        Console.WriteLine("Span Modified");
        Console.WriteLine("span[1] = 999");

        Console.WriteLine();
        Console.WriteLine("Array After");

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Memory Visualization");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("+----+-----+----+----+----+");
        Console.WriteLine("|10  |999  |30  |40  |50  |");
        Console.WriteLine("+----+-----+----+----+----+");
        Console.WriteLine("      ^");
        Console.WriteLine("Span points here.");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Span does NOT own the data.");
        Console.WriteLine("It simply references");
        Console.WriteLine("existing memory.");
        Console.WriteLine("Changing the Span");
        Console.WriteLine("changes the original array.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that Span does not copy data.
    /// </summary>
    private void SpanDoesNotCopyData()
    {
        Console.WriteLine("Span Does Not Copy Data");
        Console.WriteLine("--------------------------------------------------");

        int[] source =
        [
            100,
            200,
            300
        ];

        Span<int> span = source;

        source[0] = 777;

        Console.WriteLine("Array");

        foreach (int number in source)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Span");

        foreach (int number in span)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("There is only one copy");
        Console.WriteLine("of the data.");
        Console.WriteLine("Both variables");
        Console.WriteLine("reference the same memory.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates modifying data through Span.
    /// </summary>
    private void ModifyElementThroughSpan()
    {
        Console.WriteLine("Modify Element Through Span");
        Console.WriteLine("--------------------------------------------------");

        int[] values =
        [
            1,
            2,
            3,
            4,
            5
        ];

        Span<int> span = values;

        Console.WriteLine("Before");

        foreach (int value in values)
            Console.Write($"{value} ");

        Console.WriteLine();
        Console.WriteLine();

        span[3] = 500;

        Console.WriteLine("After");

        foreach (int value in values)
            Console.Write($"{value} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Updating the Span");
        Console.WriteLine("updates the original");
        Console.WriteLine("array immediately.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating a Span from an array.
    /// </summary>
    private void CreateSpanFromArray()
    {
        Console.WriteLine("Create Span From Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30,
            40
        ];

        Span<int> span = numbers;

        Console.WriteLine($"Array Length : {numbers.Length}");
        Console.WriteLine($"Span Length  : {span.Length}");

        Console.WriteLine();

        foreach (int item in span)
            Console.WriteLine(item);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A Span can be created");
        Console.WriteLine("directly from an array.");
        Console.WriteLine("No allocation occurs.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating a Span from stackalloc.
    /// </summary>
    private void CreateSpanUsingStackalloc()
    {
        Console.WriteLine("Create Span Using stackalloc");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers = stackalloc int[]
        {
            10,
            20,
            30,
            40
        };

        foreach (int number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("stackalloc allocates");
        Console.WriteLine("memory on the stack.");
        Console.WriteLine("Span provides access");
        Console.WriteLine("to that memory.");
        Console.WriteLine();
    }
}