namespace LR_4;

public class Pinguin : Bird
{
    public override void DefendEgg()
    {
        Console.WriteLine("Hit the enemy");
    }

    public override void Dance()
    {
        Console.WriteLine("Shake your body");
    }

    public override void ProduceEgg()
    {
        Console.WriteLine("Some magic happens");
    }

    public override void SearchForSpause()
    {
        Console.WriteLine("Time to search for the spause");
        this.Sing();
    }

    public override void Sing()
    {
        Console.WriteLine("Some Iron Maiden song from 80-th");
    }

    public override void Walk()
    {
        Console.WriteLine("Walk this way");
    }
}
