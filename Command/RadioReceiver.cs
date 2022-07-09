using UnityEngine;

// Hudson Schumaker
// SchumakerTeam
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
