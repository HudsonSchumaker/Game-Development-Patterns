// Hudson Schumaker


abstract public class Missle
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
