namespace Visitor;

public interface IShapeVisitor
{
    void Visit(Sphere sphere);
    void Visit(Parallelepiped parallelepiped);
    void Visit(Torus torus);
    void Visit(Cube cube);
}
