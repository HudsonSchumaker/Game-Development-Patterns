using UnityEngine;

// Hudson Schumaker
// SchumakerTeam
// Unity 3D
// C#

public class RadioReceiver : RemoteControlDevice
{
    public override void TurnOn()
    {
        Debug.Log("Radio is turned on.");
    }

    public override void TurnOff()
    {
        Debug.Log("Radio is turned off.");
    }
}
