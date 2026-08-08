using System.Text;
using CollectionExpressions.Concepts;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "C# 12 - Collection Expressions";

Console.WriteLine("============================================================");
Console.WriteLine("C# 12 in a Nutshell");
Console.WriteLine("Chapter 1 - Collection Expressions");
Console.WriteLine("============================================================");
Console.WriteLine();

var whyCollectionExpressions = new WhyCollectionExpressions();
whyCollectionExpressions.Run();

var arrays = new Arrays();
arrays.Run();

var lists = new Lists();
lists.Run();

var spans = new Spans();
spans.Run();

var spreadOperator = new SpreadOperator();
spreadOperator.Run();

var targetTyping = new TargetTyping();
targetTyping.Run();

Console.WriteLine();
Console.WriteLine("============================================================");
Console.WriteLine("End of Demo");
Console.WriteLine("============================================================");

Console.ReadKey();