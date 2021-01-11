// Hudson Schumaker

abstract public class RifleDecorator : IRifle
{
    protected IRifle decoretedRifle;
    
    public RifleDecorator(IRifle rifle)
    {
        decoretedRifle = rifle;
    }
    
    public virtual float GetAccuracy()
    {
        return decoratedRifle.GetAccuracy();
    }
}
