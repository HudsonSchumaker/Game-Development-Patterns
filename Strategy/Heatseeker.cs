using UnityEngine;

public class Heatseeker : ISeekBehaviour
{
    public void Seek()
    {
        Debug.Log("Seeking target with heat signature.");
    }
}
