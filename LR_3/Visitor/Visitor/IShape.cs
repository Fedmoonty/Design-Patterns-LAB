namespace Visitor;

public interface IShape
{
    void Accept(IShapeVisitor visitor);
}
