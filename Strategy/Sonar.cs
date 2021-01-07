using UnityEngine;

public class Sonar : ISeekBehaviour
{
    public void Seek()
    {
        Debug.Log("Seeking target with sonar.");
    }
}
