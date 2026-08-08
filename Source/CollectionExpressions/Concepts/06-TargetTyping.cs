using CollectionExpressions.RealWorld;

namespace CollectionExpressions.Concepts;

internal class TargetTyping
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("============================================================");
        Console.WriteLine("06 - Target Typing");
        Console.WriteLine("============================================================");
        Console.WriteLine();

        WhatIsTargetTyping();
        WhyTargetTypingExists();
        TraditionalInitialization();
        TargetTypingInitialization();
        CompareTraditionalVsTargetTyping();
        TargetTypingArray();
        TargetTypingStringArray();
        TargetTypingObjectArray();
        TargetTypingEmptyArray();
        TargetTypingList();
        TargetTypingStringList();
        TargetTypingObjectList();
        TargetTypingEmptyList();
        ListBehaviorAfterCreation();
        CompareArrayAndList();
        VarDoesNotWork();
        TargetTypingSpan();
        SpanCanBeModified();
        TargetTypingReadOnlySpan();
        CompareArrayAndSpan();
        SpanHasNoAddMethod();
        CompareArrayListAndSpan();
        TargetTypingIEnumerable();
        TargetTypingIReadOnlyList();
        TargetTypingICollection();
        TargetTypingIReadOnlyCollection();
        RuntimeTypeMayBeDifferent();
        MethodParameterTargetTyping();
        MethodReturnTargetTyping();
        MethodReturnList();
        LocalFunctionTargetTyping();
        LambdaTargetTyping();
    }

    /// <summary>
    /// Introduces the concept of Target Typing.
    /// </summary>
    private void WhatIsTargetTyping()
    {
        Console.WriteLine("What Is Target Typing");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine($"Type : {numbers.GetType().Name}");
        Console.WriteLine();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The compiler looks at");
        Console.WriteLine("the left-hand side.");
        Console.WriteLine();
        Console.WriteLine("Target Type : int[]");
        Console.WriteLine();
        Console.WriteLine("Therefore");
        Console.WriteLine("the Collection Expression");
        Console.WriteLine("creates an int array.");
        Console.WriteLine();
    }

    /// <summary>
    /// Explains why Target Typing exists.
    /// </summary>
    private void WhyTargetTypingExists()
    {
        Console.WriteLine("Why Target Typing Exists");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Collection Expression");

        Console.WriteLine();

        Console.WriteLine("[");

        Console.WriteLine("    1,");

        Console.WriteLine("    2,");

        Console.WriteLine("    3");

        Console.WriteLine("]");

        Console.WriteLine();

        Console.WriteLine("Question");

        Console.WriteLine();

        Console.WriteLine("Is this");

        Console.WriteLine("Array ?");

        Console.WriteLine("List ?");

        Console.WriteLine("Span ?");

        Console.WriteLine();

        Console.WriteLine("Answer");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("The compiler");

        Console.WriteLine("cannot know");

        Console.WriteLine("until it sees");

        Console.WriteLine("the Target Type.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates the traditional syntax.
    /// </summary>
    private void TraditionalInitialization()
    {
        Console.WriteLine("Traditional Initialization");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers = new int[]
        {
            10,
            20,
            30
        };

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Before C# 12");

        Console.WriteLine("the collection type");

        Console.WriteLine("had to be written");

        Console.WriteLine("explicitly.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing.
    /// </summary>
    private void TargetTypingInitialization()
    {
        Console.WriteLine("Target Typing Initialization");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30
        ];

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("The compiler");

        Console.WriteLine("already knows");

        Console.WriteLine("that the target");

        Console.WriteLine("is int[].");

        Console.WriteLine();

        Console.WriteLine("Therefore");

        Console.WriteLine("it creates");

        Console.WriteLine("an int array.");

        Console.WriteLine();
    }

    /// <summary>
    /// Compares traditional syntax with Target Typing.
    /// </summary>
    private void CompareTraditionalVsTargetTyping()
    {
        Console.WriteLine("Compare Traditional vs Target Typing");
        Console.WriteLine("--------------------------------------------------");

        int[] traditional = new int[]
        {
            1,
            2,
            3
        };

        int[] modern =
        [
            1,
            2,
            3
        ];

        Console.WriteLine("Traditional");

        foreach (int number in traditional)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Target Typing");

        foreach (int number in modern)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Both collections");

        Console.WriteLine("are exactly");

        Console.WriteLine("the same.");

        Console.WriteLine();

        Console.WriteLine("Only the syntax");

        Console.WriteLine("has changed.");

        Console.WriteLine();

        Console.WriteLine("The compiler");

        Console.WriteLine("uses the");

        Console.WriteLine("Target Type");

        Console.WriteLine("to determine");

        Console.WriteLine("what to create.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with an integer array.
    /// </summary>
    private void TargetTypingArray()
    {
        Console.WriteLine("Target Typing - Array<int>");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine($"Runtime Type : {numbers.GetType().Name}");
        Console.WriteLine();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Target Type");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("int[]");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Because the target type");
        Console.WriteLine("is int[],");
        Console.WriteLine("the compiler creates");
        Console.WriteLine("an integer array.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with a string array.
    /// </summary>
    private void TargetTypingStringArray()
    {
        Console.WriteLine("Target Typing - String Array");
        Console.WriteLine("--------------------------------------------------");

        string[] countries =
        [
            "Iran",
            "Germany",
            "Canada"
        ];

        Console.WriteLine($"Runtime Type : {countries.GetType().Name}");
        Console.WriteLine();

        foreach (string country in countries)
            Console.WriteLine(country);

        Console.WriteLine();

        Console.WriteLine("Target Type");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("string[]");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The Collection Expression");
        Console.WriteLine("did not change.");
        Console.WriteLine();
        Console.WriteLine("Only the target type");
        Console.WriteLine("changed from int[]");
        Console.WriteLine("to string[].");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with custom objects.
    /// </summary>
    private void TargetTypingObjectArray()
    {
        Console.WriteLine("Target Typing - Object Array");
        Console.WriteLine("--------------------------------------------------");

        Student[] students =
        [
            new Student(1, "Ali"),
            new Student(2, "Sara"),
            new Student(3, "Reza")
        ];

        Console.WriteLine($"Runtime Type : {students.GetType().Name}");
        Console.WriteLine();

        foreach (Student student in students)
            Console.WriteLine(student);

        Console.WriteLine();

        Console.WriteLine("Target Type");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Student[]");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Target Typing");
        Console.WriteLine("works for");
        Console.WriteLine("custom object arrays");
        Console.WriteLine("exactly like");
        Console.WriteLine("primitive arrays.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with an empty array.
    /// </summary>
    private void TargetTypingEmptyArray()
    {
        Console.WriteLine("Target Typing - Empty Array");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers = [];

        Console.WriteLine($"Length : {numbers.Length}");

        Console.WriteLine();

        Console.WriteLine("Target Type");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("int[]");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Without the target type,");
        Console.WriteLine("the compiler would not know");
        Console.WriteLine("what kind of");
        Console.WriteLine("empty collection");
        Console.WriteLine("should be created.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with List<int>.
    /// </summary>
    private void TargetTypingList()
    {
        Console.WriteLine("Target Typing - List<int>");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine($"Runtime Type : {numbers.GetType().Name}");
        Console.WriteLine($"Count        : {numbers.Count}");

        Console.WriteLine();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Target Type");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("List<int>");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The Collection Expression");
        Console.WriteLine("did not change.");
        Console.WriteLine();
        Console.WriteLine("The target type");
        Console.WriteLine("is List<int>.");
        Console.WriteLine();
        Console.WriteLine("Therefore");
        Console.WriteLine("the compiler creates");
        Console.WriteLine("a List<int>.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with List<string>.
    /// </summary>
    private void TargetTypingStringList()
    {
        Console.WriteLine("Target Typing - List<string>");
        Console.WriteLine("--------------------------------------------------");

        List<string> countries =
        [
            "Iran",
            "Germany",
            "Canada",
            "Japan"
        ];

        Console.WriteLine($"Runtime Type : {countries.GetType().Name}");

        Console.WriteLine();

        foreach (string country in countries)
            Console.WriteLine(country);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The compiler");
        Console.WriteLine("creates");
        Console.WriteLine("List<string>");
        Console.WriteLine("because the");
        Console.WriteLine("target type");
        Console.WriteLine("is List<string>.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with List<Student>.
    /// </summary>
    private void TargetTypingObjectList()
    {
        Console.WriteLine("Target Typing - List<Student>");
        Console.WriteLine("--------------------------------------------------");

        List<Student> students =
        [
            new Student(1, "Ali"),
            new Student(2, "Sara"),
            new Student(3, "Reza")
        ];

        Console.WriteLine($"Runtime Type : {students.GetType().Name}");

        Console.WriteLine();

        foreach (Student student in students)
            Console.WriteLine(student);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Target Typing");
        Console.WriteLine("works exactly");
        Console.WriteLine("the same");
        Console.WriteLine("for custom objects.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating an empty List.
    /// </summary>
    private void TargetTypingEmptyList()
    {
        Console.WriteLine("Target Typing - Empty List");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers = [];

        Console.WriteLine($"Count : {numbers.Count}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The compiler");
        Console.WriteLine("creates");
        Console.WriteLine("an empty");
        Console.WriteLine("List<int>.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that List methods are available.
    /// </summary>
    private void ListBehaviorAfterCreation()
    {
        Console.WriteLine("List Behavior After Creation");
        Console.WriteLine("--------------------------------------------------");

        List<int> numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine("Before Add");

        foreach (int item in numbers)
            Console.Write($"{item} ");

        Console.WriteLine();

        numbers.Add(40);
        numbers.Add(50);

        Console.WriteLine();
        Console.WriteLine("After Add");

        foreach (int item in numbers)
            Console.Write($"{item} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("After creation,");
        Console.WriteLine("this is a normal");
        Console.WriteLine("List<int>.");
        Console.WriteLine();
        Console.WriteLine("All List methods");
        Console.WriteLine("are available.");
        Console.WriteLine();
    }

    /// <summary>
    /// Compares Array and List using the same Collection Expression.
    /// </summary>
    private void CompareArrayAndList()
    {
        Console.WriteLine("Compare Array And List");
        Console.WriteLine("--------------------------------------------------");

        int[] array =
        [
            1,
            2,
            3
        ];

        List<int> list =
        [
            1,
            2,
            3
        ];

        Console.WriteLine($"Array Runtime Type : {array.GetType().Name}");
        Console.WriteLine($"List Runtime Type  : {list.GetType().Name}");

        Console.WriteLine();

        Console.WriteLine("Visualization");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Collection Expression");

        Console.WriteLine("[1, 2, 3]");

        Console.WriteLine();

        Console.WriteLine("Target Type");

        Console.WriteLine("int[]");
        Console.WriteLine("↓");
        Console.WriteLine("Array");

        Console.WriteLine();

        Console.WriteLine("Target Type");

        Console.WriteLine("List<int>");
        Console.WriteLine("↓");
        Console.WriteLine("List");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Exactly the same");
        Console.WriteLine("Collection Expression");
        Console.WriteLine("creates different");
        Console.WriteLine("objects because");
        Console.WriteLine("the Target Type");
        Console.WriteLine("is different.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that var cannot infer the type.
    /// </summary>
    private void VarDoesNotWork()
    {
        Console.WriteLine("Why 'var' Does Not Work");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("The following code does NOT compile:");
        Console.WriteLine();

        Console.WriteLine("var numbers = [1, 2, 3];");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The compiler");
        Console.WriteLine("cannot infer");
        Console.WriteLine("whether");
        Console.WriteLine("the collection");
        Console.WriteLine("should be");
        Console.WriteLine("an Array,");
        Console.WriteLine("a List,");
        Console.WriteLine("or a Span.");
        Console.WriteLine();
        Console.WriteLine("A Collection Expression");
        Console.WriteLine("requires");
        Console.WriteLine("a Target Type.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with Span<int>.
    /// </summary>
    private void TargetTypingSpan()
    {
        Console.WriteLine("Target Typing - Span<int>");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers =
        [
            10,
            20,
            30,
            40
        ];

        Console.WriteLine($"Length : {numbers.Length}");

        Console.WriteLine();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Target Type");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Span<int>");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The Collection Expression");
        Console.WriteLine("did not change.");
        Console.WriteLine();
        Console.WriteLine("The compiler sees");
        Console.WriteLine("Span<int> on the");
        Console.WriteLine("left-hand side.");
        Console.WriteLine();
        Console.WriteLine("Therefore");
        Console.WriteLine("it creates");
        Console.WriteLine("a Span<int>.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates modifying a Span.
    /// </summary>
    private void SpanCanBeModified()
    {
        Console.WriteLine("Span Can Be Modified");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine("Before");

        foreach (int item in numbers)
            Console.Write($"{item} ");

        Console.WriteLine();

        numbers[1] = 999;

        Console.WriteLine();

        Console.WriteLine("After");

        foreach (int item in numbers)
            Console.Write($"{item} ");

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Span<T>");
        Console.WriteLine("provides");
        Console.WriteLine("mutable access");
        Console.WriteLine("to its elements.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with ReadOnlySpan<char>.
    /// </summary>
    private void TargetTypingReadOnlySpan()
    {
        Console.WriteLine("Target Typing - ReadOnlySpan<char>");
        Console.WriteLine("--------------------------------------------------");

        ReadOnlySpan<char> letters =
        [
            'A',
            'B',
            'C',
            'D'
        ];

        Console.WriteLine($"Length : {letters.Length}");

        Console.WriteLine();

        foreach (char letter in letters)
            Console.Write($"{letter} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Target Type");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("ReadOnlySpan<char>");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The compiler");
        Console.WriteLine("creates");
        Console.WriteLine("a ReadOnlySpan<char>");
        Console.WriteLine("because of");
        Console.WriteLine("the Target Type.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Span and Array side by side.
    /// </summary>
    private void CompareArrayAndSpan()
    {
        Console.WriteLine("Compare Array And Span");
        Console.WriteLine("--------------------------------------------------");

        int[] array =
        [
            1,
            2,
            3
        ];

        Span<int> span =
        [
            1,
            2,
            3
        ];

        Console.WriteLine($"Array Runtime Type : {array.GetType().Name}");
        Console.WriteLine($"Span Length        : {span.Length}");

        Console.WriteLine();

        Console.WriteLine("Visualization");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("[1,2,3]");

        Console.WriteLine();

        Console.WriteLine("Target Type");

        Console.WriteLine("int[]");

        Console.WriteLine("↓");

        Console.WriteLine("Array");

        Console.WriteLine();

        Console.WriteLine("Target Type");

        Console.WriteLine("Span<int>");

        Console.WriteLine("↓");

        Console.WriteLine("Span");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Exactly the same");
        Console.WriteLine("Collection Expression");
        Console.WriteLine("produces");
        Console.WriteLine("different results");
        Console.WriteLine("because");
        Console.WriteLine("the Target Type");
        Console.WriteLine("changed.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that Span behaves differently from List.
    /// </summary>
    private void SpanHasNoAddMethod()
    {
        Console.WriteLine("Span Has No Add Method");
        Console.WriteLine("--------------------------------------------------");

        Span<int> numbers =
        [
            10,
            20,
            30
        ];

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Span<T>");
        Console.WriteLine("is NOT List<T>.");
        Console.WriteLine();
        Console.WriteLine("It has");
        Console.WriteLine("no Add()");
        Console.WriteLine("no Remove()");
        Console.WriteLine("no Insert()");
        Console.WriteLine();
        Console.WriteLine("Its length");
        Console.WriteLine("cannot change.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that only the Target Type changed.
    /// </summary>
    private void CompareArrayListAndSpan()
    {
        Console.WriteLine("Compare Array, List and Span");
        Console.WriteLine("--------------------------------------------------");

        int[] array =
        [
            1,
            2,
            3
        ];

        List<int> list =
        [
            1,
            2,
            3
        ];

        Span<int> span =
        [
            1,
            2,
            3
        ];

        Console.WriteLine("Collection Expression");

        Console.WriteLine();

        Console.WriteLine("[1, 2, 3]");

        Console.WriteLine();

        Console.WriteLine("Result");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("int[]");
        Console.WriteLine("↓");
        Console.WriteLine(array.GetType().Name);

        Console.WriteLine();

        Console.WriteLine("List<int>");
        Console.WriteLine("↓");
        Console.WriteLine(list.GetType().Name);

        Console.WriteLine();

        Console.WriteLine("Span<int>");
        Console.WriteLine("↓");
        Console.WriteLine("Span<int>");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The Collection Expression");
        Console.WriteLine("never changed.");
        Console.WriteLine();
        Console.WriteLine("Only the");
        Console.WriteLine("Target Type");
        Console.WriteLine("changed.");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with IEnumerable<int>.
    /// </summary>
    private void TargetTypingIEnumerable()
    {
        Console.WriteLine("Target Typing - IEnumerable<int>");
        Console.WriteLine("--------------------------------------------------");

        IEnumerable<int> numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine($"Runtime Type : {numbers.GetType().Name}");

        Console.WriteLine();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("The target type");
        Console.WriteLine("is IEnumerable<int>.");

        Console.WriteLine();

        Console.WriteLine("The compiler creates");
        Console.WriteLine("a collection that");
        Console.WriteLine("implements");
        Console.WriteLine("IEnumerable<int>.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with IReadOnlyList<int>.
    /// </summary>
    private void TargetTypingIReadOnlyList()
    {
        Console.WriteLine("Target Typing - IReadOnlyList<int>");
        Console.WriteLine("--------------------------------------------------");

        IReadOnlyList<int> numbers =
        [
            1,
            2,
            3,
            4
        ];

        Console.WriteLine($"Runtime Type : {numbers.GetType().Name}");

        Console.WriteLine();

        Console.WriteLine($"Count : {numbers.Count}");

        Console.WriteLine();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("The collection");
        Console.WriteLine("is exposed");
        Console.WriteLine("as read-only.");

        Console.WriteLine();

        Console.WriteLine("Consumers");
        Console.WriteLine("cannot modify");
        Console.WriteLine("the collection");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with ICollection<int>.
    /// </summary>
    private void TargetTypingICollection()
    {
        Console.WriteLine("Target Typing - ICollection<int>");
        Console.WriteLine("--------------------------------------------------");

        ICollection<int> numbers =
        [
            10,
            20,
            30
        ];

        Console.WriteLine($"Runtime Type : {numbers.GetType().Name}");

        Console.WriteLine();

        Console.WriteLine($"Count : {numbers.Count}");

        Console.WriteLine();

        numbers.Add(40);

        Console.WriteLine("After Add");

        Console.WriteLine();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Although the");
        Console.WriteLine("target type");
        Console.WriteLine("is an interface,");

        Console.WriteLine();

        Console.WriteLine("the runtime object");
        Console.WriteLine("is mutable.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with IReadOnlyCollection<int>.
    /// </summary>
    private void TargetTypingIReadOnlyCollection()
    {
        Console.WriteLine("Target Typing - IReadOnlyCollection<int>");
        Console.WriteLine("--------------------------------------------------");

        IReadOnlyCollection<int> numbers =
        [
            5,
            10,
            15,
            20
        ];

        Console.WriteLine($"Runtime Type : {numbers.GetType().Name}");

        Console.WriteLine();

        Console.WriteLine($"Count : {numbers.Count}");

        Console.WriteLine();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Read-only");
        Console.WriteLine("interfaces");

        Console.WriteLine("prevent");

        Console.WriteLine("modification");

        Console.WriteLine("through");

        Console.WriteLine("the interface.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates that the runtime type
    /// may differ from the target type.
    /// </summary>
    private void RuntimeTypeMayBeDifferent()
    {
        Console.WriteLine("Runtime Type May Be Different");
        Console.WriteLine("--------------------------------------------------");

        IEnumerable<int> enumerable =
        [
            1,
            2,
            3
        ];

        IReadOnlyList<int> readOnly =
        [
            1,
            2,
            3
        ];

        ICollection<int> collection =
        [
            1,
            2,
            3
        ];

        Console.WriteLine($"IEnumerable Runtime Type : {enumerable.GetType().FullName}");

        Console.WriteLine();

        Console.WriteLine($"IReadOnlyList Runtime Type : {readOnly.GetType().FullName}");

        Console.WriteLine();

        Console.WriteLine($"ICollection Runtime Type : {collection.GetType().FullName}");

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Target Type");

        Console.WriteLine("and");

        Console.WriteLine("Runtime Type");

        Console.WriteLine("are not always");

        Console.WriteLine("the same.");

        Console.WriteLine();

        Console.WriteLine("This is normal");

        Console.WriteLine("and expected.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with method parameters.
    /// </summary>
    private void MethodParameterTargetTyping()
    {
        Console.WriteLine("Method Parameter Target Typing");
        Console.WriteLine("--------------------------------------------------");

        void PrintNumbers(int[] numbers)
        {
            Console.WriteLine("Inside PrintNumbers");

            foreach (int number in numbers)
                Console.Write($"{number} ");

            Console.WriteLine();
        }

        PrintNumbers(
        [
            10,
            20,
            30,
            40
        ]);

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("The Collection Expression");
        Console.WriteLine("does not specify");
        Console.WriteLine("its own type.");

        Console.WriteLine();

        Console.WriteLine("The parameter type");

        Console.WriteLine("becomes");

        Console.WriteLine("the Target Type.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing with method return values.
    /// </summary>
    private void MethodReturnTargetTyping()
    {
        Console.WriteLine("Method Return Target Typing");
        Console.WriteLine("--------------------------------------------------");

        int[] CreateNumbers()
        {
            return
            [
                1,
                2,
                3,
                4,
                5
            ];
        }

        int[] numbers = CreateNumbers();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("The method");

        Console.WriteLine("returns");

        Console.WriteLine("int[]");

        Console.WriteLine();

        Console.WriteLine("Therefore");

        Console.WriteLine("the Collection Expression");

        Console.WriteLine("inside the method");

        Console.WriteLine("also knows");

        Console.WriteLine("its Target Type.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates returning List<int>.
    /// </summary>
    private void MethodReturnList()
    {
        Console.WriteLine("Method Return List");
        Console.WriteLine("--------------------------------------------------");

        List<int> CreateList()
        {
            return
            [
                10,
                20,
                30
            ];
        }

        List<int> numbers = CreateList();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("The method");

        Console.WriteLine("returns");

        Console.WriteLine("List<int>.");

        Console.WriteLine();

        Console.WriteLine("The compiler");

        Console.WriteLine("creates");

        Console.WriteLine("a List.");

        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates Target Typing inside local functions.
    /// </summary>
    private void LocalFunctionTargetTyping()
    {
        Console.WriteLine("Local Function Target Typing");
        Console.WriteLine("--------------------------------------------------");

        int[] numbers = Build();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Local functions");

        Console.WriteLine("also provide");

        Console.WriteLine("Target Types.");

        Console.WriteLine();

        int[] Build()
        {
            return
            [
                100,
                200,
                300
            ];
        }
    }

    /// <summary>
    /// Demonstrates Target Typing inside lambdas.
    /// </summary>
    private void LambdaTargetTyping()
    {
        Console.WriteLine("Lambda Target Typing");
        Console.WriteLine("--------------------------------------------------");

        Func<int[]> builder =
            () =>
            [
                5,
                10,
                15
            ];

        int[] numbers = builder();

        foreach (int number in numbers)
            Console.Write($"{number} ");

        Console.WriteLine();

        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("The delegate");

        Console.WriteLine("return type");

        Console.WriteLine("becomes");

        Console.WriteLine("the Target Type.");

        Console.WriteLine();
    }
}