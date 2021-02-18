// Hudson Schumaker
public class Enemy : ICopyable
{
    public ICopyable Copy() 
    {
        return new (this);
    }
}
