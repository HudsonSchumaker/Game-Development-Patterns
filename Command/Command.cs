// Hudson Schumaker

abstract class Command
{
    protected RemoteControlDevice remoteControlDevice;
    public Command(RemoteControlDevice rcd)
    {
        remoteControlDevice = rcd;
    }
    public abstract void Execute();
}
