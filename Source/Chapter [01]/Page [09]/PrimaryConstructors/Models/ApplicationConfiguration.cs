namespace PrimaryConstructors.Models;

internal class ApplicationConfiguration(string applicationName,
                                        string version)
{
    public string ApplicationName { get; } = applicationName;

    public string Version { get; } = version;

    public override string ToString()
    {
        return $"{ApplicationName} ({Version})";
    }
}