namespace LR_4;

public class PinguinFactory : IBirdFactory
{
    public Bird CreateBird() => new Pinguin();
}
