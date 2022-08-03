// Hudson Schumaker
// Schumaker Team
// Unity 3D
// C#

abstract class Command
{
    protected RemoteControlDevice remoteControlDevice;
    public Command(RemoteControlDevice rcd)
    {
        remoteControlDevice = rcd;
    }
    public abstract void Execute();
}
