namespace Protocol_Stack;

public class DataLinkLayer : IProtocolLayer
{
    public string ProcessData(string data)
    {
        return $"[Канальный уровень] Добавление MAC-адреса: {data}";
    }
}
