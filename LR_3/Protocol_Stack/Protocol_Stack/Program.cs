namespace Protocol_Stack;

public class Program
{
    public static void Main()
    {
        var protocolStack = new ProtocolStack();
        string data = "----Data----";
        string result = protocolStack.SendData(data);

        Console.WriteLine("Передача данных через стек протоколов:");
        Console.WriteLine(result);
    }
}
