namespace Protocol_Stack;

public class ApplicationLayer : IProtocolLayer
{
    public string ProcessData(string data)
    {
        return $"[Прикладной уровень] Форматирование HTTP-запроса: {data}";
    }
}
