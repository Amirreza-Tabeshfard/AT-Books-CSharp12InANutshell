namespace PrimaryConstructors.Models;

internal class Logger(string applicationName)
{
    public string ApplicationName { get; } = applicationName;

    public void Log(string message)
    {
        Console.WriteLine($"[{ApplicationName}] {message}");
    }
}