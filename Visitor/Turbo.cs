// Hudson Schumaker
public class Turbo : ICarPart
{
    void Accept(ICarPartVisitor visitor)
    {
        visitor.Visit(this);
    }
}
