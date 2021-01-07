// Hudson Schumaker

abstract public class Missile
{
    protected ISeekBehaviour seekBehaviour;

    public void ApplySeek()
    {
        seekBehaviour.Seek();
    }
    
    public void SetSeekBehaviour(ISeekBehaviour seekType)
    {
        seeBehaviour = seekType;
    }
}
