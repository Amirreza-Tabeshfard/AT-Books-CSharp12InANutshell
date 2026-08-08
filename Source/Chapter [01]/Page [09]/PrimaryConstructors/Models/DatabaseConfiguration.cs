namespace PrimaryConstructors.Models;

internal class DatabaseConfiguration(string server,
                                     string database,
                                     bool trustedConnection)
{
    public string Server { get; } = server;

    public string Database { get; } = database;

    public bool TrustedConnection { get; } = trustedConnection;

    public override string ToString()
    {
        return $"{Server} | {Database}";
    }
}