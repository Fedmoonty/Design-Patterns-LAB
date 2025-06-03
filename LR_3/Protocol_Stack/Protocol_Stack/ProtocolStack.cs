namespace Protocol_Stack;

public class ProtocolStack
{
    private readonly IProtocolLayer[] layers;

    public ProtocolStack()
    {
        layers = new IProtocolLayer[]
        {
            new PhysicalLayer(),
            new DataLinkLayer(),
            new NetworkLayer(),
            new TransportLayer(),
            new ApplicationLayer()
        };
    }

    public string SendData(string data)
    {
        foreach (var layer in layers)
        {
            data = layer.ProcessData(data);
        }
        return data;
    }
}

