namespace Visitor;

public class VolumeCalculator : IShapeVisitor
{
    public void Visit(Sphere sphere)
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(sphere.Radius, 3);
        Console.WriteLine($"Объем сферы: {volume}");
    }

    public void Visit(Parallelepiped parallelepiped)
    {
        double volume = parallelepiped.Length * parallelepiped.Width * parallelepiped.Height;
        Console.WriteLine($"Объем параллелепипеда: {volume}");
    }

    public void Visit(Torus torus)
    {
        double volume = (2 * Math.PI * torus.MinorRadius) * (Math.PI * Math.Pow(torus.MajorRadius, 2));
        Console.WriteLine($"Объем тора: {volume}");
    }

    public void Visit(Cube cube)
    {
        double volume = Math.Pow(cube.Side, 3);
        Console.WriteLine($"Объем куба: {volume}");
    }
}
