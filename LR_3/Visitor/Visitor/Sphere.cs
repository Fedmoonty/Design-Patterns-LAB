namespace Visitor;

public class Sphere : IShape
{
    public double Radius { get; }

    public Sphere(double radius) => Radius = radius;

    public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
}
