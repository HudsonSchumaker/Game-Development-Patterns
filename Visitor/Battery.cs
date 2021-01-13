// Hudson Schumaker

public class Battery : ICarpart
{
    void Accept(ICarPartVisitor visitor)
    {
        visitor.Visit(this);
    }
}
