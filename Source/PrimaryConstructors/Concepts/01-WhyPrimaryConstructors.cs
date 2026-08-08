namespace PrimaryConstructors.Concepts;

internal class WhyPrimaryConstructors
{
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("=========================================================");
        Console.WriteLine("01 - Why Primary Constructors");
        Console.WriteLine("=========================================================");
        Console.WriteLine();

        ConstructorBoilerplate();
        TraditionalConstructorExample();
        BoilerplateCodeAnalysis();
        ConstructorExplosion();
        RepeatedAssignments();
        Summary();
    }

    /// <summary>
    /// Explains what boilerplate code means.
    /// </summary>
    private void ConstructorBoilerplate()
    {
        Console.WriteLine("Constructor Boilerplate");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Boilerplate code is code that developers");
        Console.WriteLine("write repeatedly without adding");
        Console.WriteLine("new business logic.");
        Console.WriteLine();

        Console.WriteLine("Example:");
        Console.WriteLine("private readonly string _name;");
        Console.WriteLine("private readonly int _age;");
        Console.WriteLine();
        Console.WriteLine("public Person(string name, int age)");
        Console.WriteLine("{");
        Console.WriteLine("    _name = name;");
        Console.WriteLine("    _age = age;");
        Console.WriteLine("}");
        Console.WriteLine();

        Console.WriteLine("Explanation");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The constructor simply copies values");
        Console.WriteLine("from parameters into fields.");
        Console.WriteLine("No real business logic exists.");
        Console.WriteLine();
    }

    /// <summary>
    /// Shows the traditional constructor style before C# 12.
    /// </summary>
    private void TraditionalConstructorExample()
    {
        Console.WriteLine("Traditional Constructor Example");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Before Primary Constructors,");
        Console.WriteLine("almost every simple class");
        Console.WriteLine("looked like this:");
        Console.WriteLine();

        Console.WriteLine("private readonly string _name;");
        Console.WriteLine("private readonly int _age;");
        Console.WriteLine();
        Console.WriteLine("public Person(string name, int age)");
        Console.WriteLine("{");
        Console.WriteLine("    _name = name;");
        Console.WriteLine("    _age = age;");
        Console.WriteLine("}");
        Console.WriteLine();

        Console.WriteLine("Every parameter usually required");
        Console.WriteLine("a matching field assignment.");
        Console.WriteLine();
    }

    /// <summary>
    /// Explains why the previous style produced boilerplate code.
    /// </summary>
    private void BoilerplateCodeAnalysis()
    {
        Console.WriteLine("Boilerplate Code Analysis");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Notice that every constructor");
        Console.WriteLine("repeats the same assignments.");
        Console.WriteLine();

        Console.WriteLine("Parameter  -> Field");
        Console.WriteLine("name       -> _name");
        Console.WriteLine("age        -> _age");
        Console.WriteLine();

        Console.WriteLine("The compiler already knows");
        Console.WriteLine("how to perform these assignments.");
        Console.WriteLine("Primary Constructors reduce");
        Console.WriteLine("this repetitive code.");
        Console.WriteLine();
    }

    /// <summary>
    /// Explains how constructor complexity grows.
    /// </summary>
    private void ConstructorExplosion()
    {
        Console.WriteLine("Constructor Explosion");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Imagine a class with");
        Console.WriteLine("10 constructor parameters.");
        Console.WriteLine();

        Console.WriteLine("That often means:");
        Console.WriteLine("- 10 private fields");
        Console.WriteLine("- 10 assignments");
        Console.WriteLine("- 20+ repetitive lines");
        Console.WriteLine();

        Console.WriteLine("The larger the class,");
        Console.WriteLine("the more repetitive");
        Console.WriteLine("the constructor becomes.");
        Console.WriteLine();
    }

    /// <summary>
    /// Explains repeated assignments.
    /// </summary>
    private void RepeatedAssignments()
    {
        Console.WriteLine("Repeated Assignments");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("_name = name;");
        Console.WriteLine("_age = age;");
        Console.WriteLine("_salary = salary;");
        Console.WriteLine("_department = department;");
        Console.WriteLine();

        Console.WriteLine("Almost every assignment");
        Console.WriteLine("has the same pattern.");
        Console.WriteLine();

        Console.WriteLine("Primary Constructors");
        Console.WriteLine("remove much of this");
        Console.WriteLine("repetitive code.");
        Console.WriteLine();
    }

    /// <summary>
    /// Summarizes the motivation.
    /// </summary>
    private void Summary()
    {
        Console.WriteLine("Summary");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Primary Constructors");
        Console.WriteLine("were introduced");
        Console.WriteLine("to reduce repetitive");
        Console.WriteLine("constructor code.");
        Console.WriteLine();

        Console.WriteLine("They make simple classes");
        Console.WriteLine("shorter, cleaner,");
        Console.WriteLine("and easier to maintain.");
        Console.WriteLine();
    }
}