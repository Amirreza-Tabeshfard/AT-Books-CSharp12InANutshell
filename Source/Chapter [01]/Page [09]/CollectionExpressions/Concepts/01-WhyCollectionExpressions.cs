namespace CollectionExpressions.Concepts;

internal class WhyCollectionExpressions
{
    public void Run()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("01 - Why Collection Expressions?");
        Console.WriteLine("==========================================");

        Console.WriteLine();
        Console.WriteLine("Problem Before C# 12");
        Console.WriteLine("--------------------");

        int[] numbersOld =
        {
            1,
            2,
            3
        };

        List<int> listOld = new()
        {
            1,
            2,
            3
        };

        Console.WriteLine($"Array Length : {numbersOld.Length}");
        Console.WriteLine($"List Count   : {listOld.Count}");

        Console.WriteLine();

        Console.WriteLine("Solution in C# 12");
        Console.WriteLine("-----------------");

        int[] numbers =
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

        Console.WriteLine($"Array Length : {numbers.Length}");
        Console.WriteLine($"List Count   : {list.Count}");

        Console.WriteLine();

        Console.WriteLine("Summary");
        Console.WriteLine("-------");
        Console.WriteLine("Collection Expression is NOT a new collection.");
        Console.WriteLine("It is only a unified syntax for creating collections.");
        Console.WriteLine();
    }
}