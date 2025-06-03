namespace LR2_2;

public class BookProxy : IBook
{
    private Book _realBook;
    private readonly User _user;

    public BookProxy(User user)
    {
        _user = user;
    }

    public void Display()
    {
        if (!_user.IsRegistered || !_user.HasAccessToBook)
        {
            Console.WriteLine($"Доступ к книге запрещен для пользователя: {_user.Username}");
            return;
        }

        if (_realBook == null)
        {
            _realBook = new Book();
        }

        _realBook.Display();
    }
}
