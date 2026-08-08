using CollectionExpressions.RealWorld;

namespace CollectionExpressions.Concepts;

internal class SpreadOperator
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("============================================================");
        Console.WriteLine("05 - Spread Operator (..)");
        Console.WriteLine("============================================================");
        Console.WriteLine();

        WhatIsSpreadOperator();
        SpreadArray();
        SpreadList();
        SpreadSpan();
        SpreadReadOnlySpan();
        MergeTwoArrays();
        MergeThreeArrays();
        MergeValuesBeforeArray();
        MergeValuesAfterArray();
        MergeValuesBeforeAndAfterArray();
        MergeMultipleCollections();
        SpreadVariable();
        SpreadMethodResult();
        SpreadLinqQuery();
        SpreadEmptyCollection();
        MultipleSpreadOperators();
        MixEverythingTogether();
        MergeStudentLists();
        BuildApiRequest();
        MergeConfiguration();
        MergeRoles();
        BuildNavigationMenu();
        MergePermissions();
        DoesSpreadCreateNewCollection();
        SpreadVsSpan();
        SpreadVsAddRange();
        CompilerMentalModel();
    }

    /// <summary>
    /// Introduces the Spread Operator.
    /// </summary>
    private void WhatIsSpreadOperator()
    {
        Console.WriteLine("What Is Spread Operator");
        Console.WriteLine("--------------------------------------------------");

        int[] source =
        [
            10,
            20,
            30
        ];

        int[] destination =
        [
            ..source
        ];

        Console.WriteLine("Source");

        foreach (int number in source)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Destination");

        foreach (int number in destination)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The Spread Operator expands");
        Console.WriteLine("every element from");
        Console.WriteLine("an existing collection.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Spread Operator with arrays.
    /// </summary>
    private void SpreadArray()
    {
        Console.WriteLine("Spread Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            1,
            2,
            3
        ];

        int[] result =
        [
            ..numbers
        ];

        Console.WriteLine("Result");

        foreach (int item in result)
            Console.WriteLine(item);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The resulting array");
        Console.WriteLine("contains every element");
        Console.WriteLine("from the source array.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Spread Operator with List.
    /// </summary>
    private void SpreadList()
    {
        Console.WriteLine("Spread List");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20,
            30
        ];

        List<int> result =
        [
            ..numbers
        ];

        foreach (int item in result)
            Console.WriteLine(item);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Spread Operator");
        Console.WriteLine("works with List<T>");
        Console.WriteLine("because List<T>");
        Console.WriteLine("implements IEnumerable<T>.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Spread Operator with Span.
    /// </summary>
    private void SpreadSpan()
    {
        Console.WriteLine("Spread Span");
        Console.WriteLine("--------------------------------------------------");

        Span<int> span =
        [
            100,
            200,
            300
        ];

        int[] result =
        [
            ..span
        ];

        foreach (int item in result)
            Console.WriteLine(item);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Span<T> can also");
        Console.WriteLine("be expanded");
        Console.WriteLine("using '..'.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Spread Operator with ReadOnlySpan.
    /// </summary>
    private void SpreadReadOnlySpan()
    {
        Console.WriteLine("Spread ReadOnlySpan");
        Console.WriteLine("--------------------------------------------------");

        ReadOnlySpan<int> span =
        [
            5,
            10,
            15,
            20
        ];

        int[] result =
        [
            ..span
        ];

        foreach (int item in result)
            Console.WriteLine(item);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("ReadOnlySpan<T>");
        Console.WriteLine("is also supported.");
        Console.WriteLine("The source collection");
        Console.WriteLine("remains read-only.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates merging two arrays.
    /// </summary>
    private void MergeTwoArrays()
    {
        Console.WriteLine("Merge Two Arrays");
        Console.WriteLine("--------------------------------------------------");

        int[] first =
        [
            10,
        20,
        30
        ];

        int[] second =
        [
            40,
        50,
        60
        ];

        int[] result =
        [
            ..first,
        ..second
        ];

        Console.WriteLine("Result");

        foreach (int item in result)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Visualization");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("First  : 10 20 30");
        Console.WriteLine("Second : 40 50 60");
        Console.WriteLine("Result : 10 20 30 40 50 60");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The Spread Operator expands");
        Console.WriteLine("both arrays into");
        Console.WriteLine("one new array.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates merging three arrays.
    /// </summary>
    private void MergeThreeArrays()
    {
        Console.WriteLine("Merge Three Arrays");
        Console.WriteLine("--------------------------------------------------");

        int[] first = [1, 2];
        int[] second = [3, 4];
        int[] third = [5, 6];

        int[] result =
        [
            ..first,
            ..second,
            ..third
        ];

        foreach (int item in result)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Any number of");
        Console.WriteLine("collections can");
        Console.WriteLine("be merged.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates placing values before the Spread Operator.
    /// </summary>
    private void MergeValuesBeforeArray()
    {
        Console.WriteLine("Merge Values Before Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            30,
            40,
            50
        ];

        int[] result =
        [
            10,
            20,
            ..numbers
        ];

        foreach (int item in result)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Visualization");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("10 20 + Array");
        Console.WriteLine("↓");
        Console.WriteLine("10 20 30 40 50");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates placing values after the Spread Operator.
    /// </summary>
    private void MergeValuesAfterArray()
    {
        Console.WriteLine("Merge Values After Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30
        ];

        int[] result =
        [
            ..numbers,
            40,
            50
        ];

        foreach (int item in result)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Visualization");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Array + 40 50");
        Console.WriteLine("↓");
        Console.WriteLine("10 20 30 40 50");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates placing values before and after.
    /// </summary>
    private void MergeValuesBeforeAndAfterArray()
    {
        Console.WriteLine("Merge Values Before And After Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            20,
            30,
            40
        ];

        int[] result =
        [
            10,
            ..numbers,
            50
        ];

        foreach (int item in result)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Visualization");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("10 + Array + 50");
        Console.WriteLine("↓");
        Console.WriteLine("10 20 30 40 50");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates merging multiple collections.
    /// </summary>
    private void MergeMultipleCollections()
    {
        Console.WriteLine("Merge Multiple Collections");
        Console.WriteLine("--------------------------------------------------");

        int[] first =
        [
            1,
            2
        ];

        List<int> second =
        [
            3,
            4
        ];

        Span<int> third =
        [
            5,
            6
        ];

        int[] result =
        [
            ..first,
            ..second,
            ..third
        ];

        foreach (int item in result)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Different collection");
        Console.WriteLine("types can participate");
        Console.WriteLine("in the same");
        Console.WriteLine("Collection Expression.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates spreading a variable.
    /// </summary>
    private void SpreadVariable()
    {
        Console.WriteLine("Spread Variable");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30
        ];

        int[] result =
        [
            ..numbers
        ];

        Console.WriteLine("Variable");

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Result");

        foreach (int number in result)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The variable 'numbers'");
        Console.WriteLine("is expanded into");
        Console.WriteLine("individual elements.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates spreading the result of a method.
    /// </summary>
    private void SpreadMethodResult()
    {
        Console.WriteLine("Spread Method Result");
        Console.WriteLine("--------------------------------------------------");

        int[] result =
        [
            ..GetNumbers()
        ];

        foreach (int number in result)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The Spread Operator");
        Console.WriteLine("can expand");
        Console.WriteLine("the collection");
        Console.WriteLine("returned by a method.");
        Console.WriteLine();
    }

    private int[] GetNumbers()
    {
        return
        [
            100,
            200,
            300
        ];
    }

    /// <summary>
    /// Demonstrates spreading a LINQ query.
    /// </summary>
    private void SpreadLinqQuery()
    {
        Console.WriteLine("Spread LINQ Query");
        Console.WriteLine("--------------------------------------------------");

        IEnumerable<int> evenNumbers = Enumerable.Range(1, 10)
                                       .Where(number => number % 2 == 0);

        int[] result =
        [
            ..evenNumbers
        ];

        foreach (int number in result)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The Spread Operator");
        Console.WriteLine("works with");
        Console.WriteLine("IEnumerable<T>.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates spreading an empty collection.
    /// </summary>
    private void SpreadEmptyCollection()
    {
        Console.WriteLine("Spread Empty Collection");
        Console.WriteLine("--------------------------------------------------");

        int[] empty = [];

        int[] result =
        [
            1,
            2,
            ..empty,
            3,
            4
        ];

        foreach (int number in result)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("An empty collection");
        Console.WriteLine("adds nothing");
        Console.WriteLine("to the result.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates multiple Spread Operators.
    /// </summary>
    private void MultipleSpreadOperators()
    {
        Console.WriteLine("Multiple Spread Operators");
        Console.WriteLine("--------------------------------------------------");

        int[] first =
        [
            1,
            2
        ];

        int[] second =
        [
            3,
            4
        ];

        int[] third =
        [
            5,
            6
        ];

        int[] result =
        [
            ..first,
            ..second,
            ..third
        ];

        foreach (int number in result)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Any number");
        Console.WriteLine("of Spread Operators");
        Console.WriteLine("can appear");
        Console.WriteLine("inside one");
        Console.WriteLine("Collection Expression.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates mixing literals, variables and methods.
    /// </summary>
    private void MixEverythingTogether()
    {
        Console.WriteLine("Mix Everything Together");
        Console.WriteLine("--------------------------------------------------");

        int[] first =
        [
            10,
            20
        ];

        int[] result =
        [
            -1,
            0,
            ..first,
            ..GetNumbers(),
            999
        ];

        foreach (int number in result)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Visualization");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("-1 0");
        Console.WriteLine("↓");
        Console.WriteLine("10 20");
        Console.WriteLine("↓");
        Console.WriteLine("100 200 300");
        Console.WriteLine("↓");
        Console.WriteLine("999");

        Console.WriteLine();
        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Collection Expressions");
        Console.WriteLine("allow literal values,");
        Console.WriteLine("variables,");
        Console.WriteLine("method results,");
        Console.WriteLine("and Spread Operators");
        Console.WriteLine("to be mixed together.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates merging two student collections.
    /// </summary>
    private void MergeStudentLists()
    {
        Console.WriteLine("Merge Student Lists");
        Console.WriteLine("--------------------------------------------------");

        List<Student> firstYear =
        [
            new Student(1, "Ali", 20, "Computer Science"),
            new Student(2, "Sara", 21, "Computer Science")
        ];

        List<Student> secondYear =
        [
            new Student(3, "Reza", 22, "Computer Science"),
            new Student(4, "Maryam", 21, "Computer Science")
        ];

        List<Student> allStudents =
        [
            ..firstYear,
            ..secondYear
        ];

        foreach (Student student in allStudents)
            Console.WriteLine(student);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Spread Operator makes");
        Console.WriteLine("merging business objects");
        Console.WriteLine("very simple.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates building an API request.
    /// </summary>
    private void BuildApiRequest()
    {
        Console.WriteLine("Build API Request");
        Console.WriteLine("--------------------------------------------------");

        string[] defaultHeaders =
        [
            "Authorization",
            "Accept"
        ];

        string[] customHeaders =
        [
            "Language",
            "TimeZone"
        ];

        string[] requestHeaders =
        [
            ..defaultHeaders,
            ..customHeaders,
            "CorrelationId"
        ];

        foreach (string header in requestHeaders)
            Console.WriteLine(header);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("A very common scenario");
        Console.WriteLine("is combining default");
        Console.WriteLine("and custom headers.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates merging application configuration.
    /// </summary>
    private void MergeConfiguration()
    {
        Console.WriteLine("Merge Configuration");
        Console.WriteLine("--------------------------------------------------");

        string[] defaults =
        [
            "Logging",
            "Caching"
        ];

        string[] production =
        [
            "Redis",
            "Azure Storage"
        ];

        string[] configuration =
        [
            ..defaults,
            ..production
        ];

        foreach (string item in configuration)
            Console.WriteLine(item);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Application configuration");
        Console.WriteLine("is often built");
        Console.WriteLine("from multiple sources.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates building application roles.
    /// </summary>
    private void MergeRoles()
    {
        Console.WriteLine("Merge Roles");
        Console.WriteLine("--------------------------------------------------");

        string[] basicRoles =
        [
            "User",
            "Customer"
        ];

        string[] adminRoles =
        [
            "Administrator",
            "Manager"
        ];

        string[] allRoles =
        [
            ..basicRoles,
            ..adminRoles
        ];

        foreach (string role in allRoles)
            Console.WriteLine(role);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Roles are frequently");
        Console.WriteLine("assembled from");
        Console.WriteLine("multiple collections.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates building a navigation menu.
    /// </summary>
    private void BuildNavigationMenu()
    {
        Console.WriteLine("Build Navigation Menu");
        Console.WriteLine("--------------------------------------------------");

        string[] commonMenu =
        [
            "Home",
            "Products",
            "About"
        ];

        string[] adminMenu =
        [
            "Dashboard",
            "Users",
            "Settings"
        ];

        string[] menu =
        [
            ..commonMenu,
            ..adminMenu,
            "Logout"
        ];

        foreach (string item in menu)
            Console.WriteLine(item);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Menus are often");
        Console.WriteLine("assembled from");
        Console.WriteLine("different modules.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates combining permissions.
    /// </summary>
    private void MergePermissions()
    {
        Console.WriteLine("Merge Permissions");
        Console.WriteLine("--------------------------------------------------");

        string[] readPermissions =
        [
            "ReadProducts",
            "ReadOrders"
        ];

        string[] writePermissions =
        [
            "CreateOrder",
            "DeleteOrder"
        ];

        string[] permissions =
        [
            ..readPermissions,
            ..writePermissions
        ];

        foreach (string permission in permissions)
            Console.WriteLine(permission);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Permission sets");
        Console.WriteLine("can easily be");
        Console.WriteLine("combined.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that the Spread Operator creates a new collection.
    /// </summary>
    private void DoesSpreadCreateNewCollection()
    {
        Console.WriteLine("Does Spread Create New Collection");
        Console.WriteLine("--------------------------------------------------");

        int[] original =
        [
            10,
            20,
            30
        ];

        int[] copied =
        [
            ..original
        ];

        copied[0] = 999;

        Console.WriteLine("Original");

        foreach (int item in original)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Copied");

        foreach (int item in copied)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Visualization");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Original");
        Console.WriteLine("+----+----+----+");
        Console.WriteLine("|10  |20  |30  |");
        Console.WriteLine("+----+----+----+");

        Console.WriteLine();

        Console.WriteLine("Copied");
        Console.WriteLine("+-----+----+----+");
        Console.WriteLine("|999  |20  |30  |");
        Console.WriteLine("+-----+----+----+");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Spread Operator creates");
        Console.WriteLine("a completely new collection.");
        Console.WriteLine("The original collection");
        Console.WriteLine("is NOT modified.");
        Console.WriteLine();
    }

    /// <summary>
    /// Compares Spread Operator with Span.
    /// </summary>
    private void SpreadVsSpan()
    {
        Console.WriteLine("Spread Operator vs Span");
        Console.WriteLine("--------------------------------------------------");

        int[] source =
        [
            10,
            20,
            30
        ];

        int[] spread =
        [
            ..source
        ];

        Span<int> span = source;

        spread[0] = 111;

        span[1] = 222;

        Console.WriteLine("Source");

        foreach (int item in source)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Spread");

        foreach (int item in spread)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Visualization");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Spread");
        Console.WriteLine();

        Console.WriteLine("Source");
        Console.WriteLine("+----+-----+----+");
        Console.WriteLine("|10  |222  |30  |");
        Console.WriteLine("+----+-----+----+");

        Console.WriteLine();

        Console.WriteLine("Spread");
        Console.WriteLine("+-----+----+----+");
        Console.WriteLine("|111  |20  |30  |");
        Console.WriteLine("+-----+----+----+");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Spread creates");
        Console.WriteLine("a NEW collection.");
        Console.WriteLine();

        Console.WriteLine("Span references");
        Console.WriteLine("EXISTING memory.");
        Console.WriteLine();

        Console.WriteLine("They are fundamentally");
        Console.WriteLine("different concepts.");
        Console.WriteLine();
    }

    /// <summary>
    /// Compares Spread Operator with AddRange.
    /// </summary>
    private void SpreadVsAddRange()
    {
        Console.WriteLine("Spread Operator vs AddRange");
        Console.WriteLine("--------------------------------------------------");

        List<int> first =
        [
            1,
            2,
            3
        ];

        List<int> second =
        [
            4,
            5,
            6
        ];

        List<int> spread =
        [
            ..first,
            ..second
        ];

        List<int> addRange =
        [
            ..first
        ];

        addRange.AddRange(second);

        Console.WriteLine("Spread");

        foreach (int item in spread)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("AddRange");

        foreach (int item in addRange)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Both produce");
        Console.WriteLine("the same values.");
        Console.WriteLine();

        Console.WriteLine("Spread is declarative.");
        Console.WriteLine("AddRange is procedural.");
        Console.WriteLine();
    }

    /// <summary>
    /// Conceptual explanation of what the compiler does.
    /// </summary>
    private void CompilerMentalModel()
    {
        Console.WriteLine("Compiler Mental Model");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Collection Expression");
        Console.WriteLine();

        Console.WriteLine("[");
        Console.WriteLine("    ..first,");
        Console.WriteLine("    ..second,");
        Console.WriteLine("    100");
        Console.WriteLine("]");

        Console.WriteLine();

        Console.WriteLine("Think of it conceptually as");

        Console.WriteLine();

        Console.WriteLine("Create destination collection");
        Console.WriteLine("Copy all elements from first");
        Console.WriteLine("Copy all elements from second");
        Console.WriteLine("Add literal value 100");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("This is NOT");
        Console.WriteLine("the exact code");
        Console.WriteLine("generated by");
        Console.WriteLine("the compiler.");

        Console.WriteLine();

        Console.WriteLine("It is only");
        Console.WriteLine("a mental model");
        Console.WriteLine("to understand");
        Console.WriteLine("Spread Operator.");
        Console.WriteLine();
    }
}