// Hudson Schumaker
public interface ICarPartVisitor
{
    void Visit(Car car);
    void Visit(Battery battery);
    void Visit(Turbo turbo);
    void Visit(Gun guns);
}
