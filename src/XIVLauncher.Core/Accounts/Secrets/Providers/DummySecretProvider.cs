namespace XIVLauncher.Core.Accounts.Secrets.Providers;

public class DummySecretProvider : ISecretProvider
{
    public string? GetPassword(string accountName)
    {
        return null;
    }

    public void SavePassword(string accountName, string password)
    {
        // ignored
    }

    public void DeletePassword(string accountName)
    {
        // ignored
    }

    public string? GetAutoLoginSessionKey(string accountName)
    {
        return null;
    }

    public void SaveAutoLoginSessionKey(string accountName, string sessionKey)
    {
        // ignored
    }

    public void DeleteAutoLoginSessionKey(string accountName)
    {
        // ignored
    }
}
