// Hudson Schumaker

public class TurnOffCommand
{
    public TurnOffCommand(RemoteControlDevice receiver) : base(receiver) {}
    
    public override void Execute()
    {
        remoteControlDevice.TurnOn();
    }
}
