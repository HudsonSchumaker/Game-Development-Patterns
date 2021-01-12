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
        
        if (Input.GetKeyDown(Keycode.S))
        {
            IRifle rifle = new WithScope(new BasicRifle());
            Debug.Log("Scope Accurancy: " + rifle.GetAccurancy());
        }
        
        if (Input.GetKeyDown(Keycode.Z))
        {
            IRifle rifle = new WithScope(new WithStabilizer(new BasicRifle()));
            Debug.Log("Scope + Stabilizer Accurancy: " + rifle.GetAccurancy());
        }
    }
}
