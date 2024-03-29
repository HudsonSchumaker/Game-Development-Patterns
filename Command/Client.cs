using UnityEngine;

// Hudson Schumaker
// Schumaker Team
// Unity 3D
// C#

public class Client : MonoBehaviour
{
        private RemoteControlDevice radioReceiver;
        private RemoteControlDevice televisionReceiver;
        private RemoteControlDevice[] devices = new RemoteControlDevice[2];

        void Start()
        {
            radioReceiver = new RadioReceiver();
            televisionReceiver = new TelevisionReceiver();

            devices[0] = radioReceiver;
            devices[1] = televisionReceiver;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Command commandTV = new TurnOnCommand(devices[0]);
                Command commandRadio = new TurnOnCommand(devices[1]);

                Invoker invoker = new Invoker();

                invoker.SetCommand(commandTV);
                invoker.ExecuteCommand();

                invoker.SetCommand(commandRadio);
                invoker.ExecuteCommand();
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                Command commandKill = new KillSwitchCommand(devices);
                Invoker invoker = new Invoker();
                invoker.SetCommand(commandKill);
                invoker.ExecuteCommand();
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press O to turn the radio and television.");
            GUI.Label(new Rect(10, 30, 500, 20), "Press K to trigger the kill switch and turn off everything.");
            GUI.Label(new Rect(10, 50, 500, 20), "Look in the Debug Console to view the status of the devices.");
        }
}
