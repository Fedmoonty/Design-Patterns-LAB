using LR_4;

namespace Coding.SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IBirdFactory> birdFactories = new List<IBirdFactory>
            {
                new SparrowFactory(),
                new PinguinFactory()
            };

            BirdHandler birdHandler = new BirdHandler(birdFactories);
            birdHandler.DoBirdAction();

            Console.ReadLine();
        }
    }
}
