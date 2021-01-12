// Hudson Schumaker

public class WithStabilizer : RifleDecorator
{
    private float stabilizerAccurancy = 10.0f;
    
    public WithStabilizer(IRifle rifle) : base(rifle) {}
    
    public override float GetAccrancy()
    {
        return base.GetAccurancy + stabilizerAccurancy;
    }
}
