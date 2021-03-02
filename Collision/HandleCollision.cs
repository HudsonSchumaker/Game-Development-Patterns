using UnityEngine;

// Hudson Schumaker
public class HandleCollision : MonoBehaviour 
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Woods"))
        {
        }

        if (collision.CompareTag("Water"))
        {
        }
    }
    
    void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
