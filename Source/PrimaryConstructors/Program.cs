using PrimaryConstructors.Concepts;

var whyPrimaryConstructors = new WhyPrimaryConstructors();
whyPrimaryConstructors.Run();

var basicClass = new BasicClass();
basicClass.Run();

var usingConstructorParameters = new UsingConstructorParameters();
usingConstructorParameters.Run();

var primaryConstructorAndProperties = new PrimaryConstructorAndProperties();
primaryConstructorAndProperties.Run();

var primaryConstructorAndMethods = new PrimaryConstructorAndMethods();
primaryConstructorAndMethods.Run();

var readonlyBehavior = new ReadonlyBehavior();
readonlyBehavior.Run();

Console.ReadKey();
Console.WriteLine("End Project");