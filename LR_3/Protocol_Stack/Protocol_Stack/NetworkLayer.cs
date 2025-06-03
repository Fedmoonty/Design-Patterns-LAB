namespace Protocol_Stack;

public class NetworkLayer : IProtocolLayer
{
    public string ProcessData(string data)
    {
        return $"[Сетевой уровень] Добавление IP-адреса: {data}";
    }
}
