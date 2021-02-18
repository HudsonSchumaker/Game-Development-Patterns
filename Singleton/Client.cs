using UnityEngine;

// Hudson Schumaker
public class Client : MonoBehavior
{
    void start() 
    {
        GameManager.instance.InitializeScene();
    }
}
