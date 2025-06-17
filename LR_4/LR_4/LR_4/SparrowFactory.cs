namespace LR_4;

public class SparrowFactory : IBirdFactory
{
    public Bird CreateBird() => new Sparrow();
}
