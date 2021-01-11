// Hudson Schumaker

public class WithScope : RifleDecorator
{
    private float scopeAccurancy = 20.0f;
    
    public WithScope(IRfile rifle) : base(rifle) {}
    
    public override float GetAccuracy()
    {
        return base.GetAccuracy() + scopeAccurancy;
    }
}
