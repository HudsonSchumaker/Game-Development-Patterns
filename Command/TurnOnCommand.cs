// Hudson Schumaker

public class TurnOnCommand : Command
{
    public TurnOnCommand(RemoteControlDevice receiver) : base(receiver) {}
    
    public override void Execute()
    {
        remoteControlDevice.TurnOn();
    }
}
