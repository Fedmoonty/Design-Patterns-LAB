namespace Visitor;

public class Program
{
    static void Main()
    {
        var shapes = new IShape[]
        {
            new Sphere(3),
            new Parallelepiped(4, 5, 6),
            new Torus(7, 2),
            new Cube(4)
        };

        var calculator = new VolumeCalculator();

        foreach (var shape in shapes)
        {
            shape.Accept(calculator);
        }
    }
}
