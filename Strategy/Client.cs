using UnityEngine;

// Hudson Schumaker
public class Client : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Missile tomahawk = ScriptableObject.CreateInstance<Tomahawk>();
            tomahawk.ApplySeek();
        }
    }
}
