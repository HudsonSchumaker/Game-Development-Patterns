// Hudson Schumaker

using UnityEngine;


public class GameManager : MonoBehavior
{
    public static GameManager instance;
    
    void Awake()
    {
        instance = this;
    }
    
    public void InitializeScene()
    {
        // Some code goes here...
    }
}
