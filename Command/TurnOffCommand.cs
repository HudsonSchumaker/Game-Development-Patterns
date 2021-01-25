// Hudson Schumaker

public class TurnOffCommand : Command
{
    public TurnOffCommand(RemoteControlDevice receiver) : base(receiver) {}
    
    public override void Execute()
    {
        remoteControlDevice.TurnOff();
    }
}
