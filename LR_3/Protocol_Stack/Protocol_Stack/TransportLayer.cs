namespace Protocol_Stack;

public class TransportLayer : IProtocolLayer
{
    public string ProcessData(string data)
    {
        return $"[Транспортный уровень] Упаковка TCP/UDP: {data}";
    }
}
