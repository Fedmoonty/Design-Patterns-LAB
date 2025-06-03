namespace Visitor;

public class Torus : IShape
{
    public double MajorRadius { get; }
    public double MinorRadius { get; }

    public Torus(double majorRadius, double minorRadius) =>
        (MajorRadius, MinorRadius) = (majorRadius, minorRadius);

    public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
}
