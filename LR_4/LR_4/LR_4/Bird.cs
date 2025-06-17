namespace LR_4;

public abstract class Bird : IWalkable, ISingable, IDanceable, IReproductive
{
    public abstract void Walk();
    public abstract void Sing();
    public abstract void Dance();
    public abstract void ProduceEgg();
    public abstract void DefendEgg();
    public abstract void SearchForSpause();
}


