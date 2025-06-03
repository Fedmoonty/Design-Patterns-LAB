namespace LR2_2;

class Program
{
    static void Main(string[] args)
    {
        // Пример: пользователь с правами доступа
        User authorizedUser = new User("Иван Иванов", isRegistered: true, hasAccessToBook: true);
        IBook proxyForAuthorizedUser = new BookProxy(authorizedUser);
        Console.WriteLine("Доступ для авторизованного пользователя:");
        proxyForAuthorizedUser.Display();

        Console.WriteLine();

        // Пример: пользователь без необходимых прав доступа
        User unauthorizedUser = new User("Петр Петров", isRegistered: true, hasAccessToBook: false);
        IBook proxyForUnauthorizedUser = new BookProxy(unauthorizedUser);
        Console.WriteLine("Попытка доступа для неавторизованного пользователя:");
        proxyForUnauthorizedUser.Display();

        Console.ReadLine();
    }
}