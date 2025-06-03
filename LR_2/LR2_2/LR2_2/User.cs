namespace LR2_2;

public class User
{
    public string Username { get; set; }
    public bool IsRegistered { get; set; }
    public bool HasAccessToBook { get; set; }

    public User(string username, bool isRegistered, bool hasAccessToBook)
    {
        Username = username;
        IsRegistered = isRegistered;
        HasAccessToBook = hasAccessToBook;
    }
}
