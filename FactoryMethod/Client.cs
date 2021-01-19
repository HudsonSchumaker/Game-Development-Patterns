using UnityEngine;

// Hudson Schumaker
public class Client : MonoBehaviour
{
    public NPCSpawer spawner;
    
    public void Update() 
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            spawer.SpawnVillagers();
        }
    }
}
