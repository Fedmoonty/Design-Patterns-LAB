namespace LR2_2;

public class Book : IBook
{
    private string _content;

    public Book()
    {
        _content = "Содержимое книги";
    }

    public void Display()
    {
        Console.WriteLine(_content);
    }
}
