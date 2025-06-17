namespace LR_4;

internal class BirdHandler
{
    private readonly IEnumerable<IBirdFactory> _birdFactories;

    public BirdHandler(IEnumerable<IBirdFactory> birdFactories)
    {
        _birdFactories = birdFactories;
    }

    public void DoBirdAction()
    {
        foreach (var factory in _birdFactories)
        {
            var bird = factory.CreateBird();

            if (bird is IWalkable walker) walker.Walk();
            if (bird is IFlyable flyer) flyer.Fly();
            if (bird is ISingable singer) singer.Sing();
            if (bird is IDanceable dancer) dancer.Dance();
            if (bird is IReproductive parent)
            {
                parent.SearchForSpause();
                parent.ProduceEgg();
                parent.DefendEgg();
            }
        }
    }
}
