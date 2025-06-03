namespace Visitor;

public class Parallelepiped : IShape
{
    public double Length { get; }
    public double Width { get; }
    public double Height { get; }

    public Parallelepiped(double length, double width, double height) =>
        (Length, Width, Height) = (length, width, height);

    public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
}
