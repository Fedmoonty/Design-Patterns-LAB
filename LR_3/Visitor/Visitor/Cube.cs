namespace Visitor;

public class Cube : IShape
{
    public double Side { get; }

    public Cube(double side) => Side = side;

    public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
}
