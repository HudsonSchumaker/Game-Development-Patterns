using UnityEngine;

// Hudson Schumaker
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
