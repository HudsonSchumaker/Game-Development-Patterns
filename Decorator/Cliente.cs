using UnityEngine;

public class Client : Monobehavior
{
    void Update()
    {
        if (Input.GetKeyDown(Keycode.A))
        {
            IRifle rifle = new BasicRifle();
            Debug.Log("Basic Accurancy: " + rifle.GetAccurancy());
        }
    }
}
