namespace Protocol_Stack
{
    public class PhysicalLayer : IProtocolLayer
    {
        public string ProcessData(string data)
        {
            return $"[Физический уровень] Передача данных: {data}";
        }
    }
}
