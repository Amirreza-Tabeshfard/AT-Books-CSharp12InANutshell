namespace PrimaryConstructors.Models;

internal class EmailConfiguration(string host,
                                  int port,
                                  bool useSsl)
{
    public string Host { get; } = host;

    public int Port { get; } = port;

    public bool UseSsl { get; } = useSsl;

    public override string ToString()
    {
        return $"{Host}:{Port} (SSL={UseSsl})";
    }
}