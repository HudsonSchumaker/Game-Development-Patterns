// Hudson Schumaker

public class TurnOnCommand
{
    public TurnOnCommand(RemoteControlDevice receiver) : base(receiver) {}
    
    public override void Execute()
    {
        remoteControlDevice.TurnOn();
    }
}
