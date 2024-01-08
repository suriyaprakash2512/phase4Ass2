using System.Collections.Generic;

public class UserAuthenticator
{
    private Dictionary<string, string> userCredentials;

    public UserAuthenticator()
    {
        userCredentials = new Dictionary<string, string>();
    }

    public bool RegisterUser(string username, string password)
    {
        if (!userCredentials.ContainsKey(username))
        {
            userCredentials.Add(username, password);
            return true;
        }
        return false;
    }

    public bool LoginUser(string username, string password)
    {
        if (userCredentials.TryGetValue(username, out string storedPassword))
        {
            return password == storedPassword;
        }
        return false;
    }
}