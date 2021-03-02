using UnityEngine;

// Hudson Schumaker
public class HandleCollision : MonoBehaviour 
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
        }

        if (collision.CompareTag("Shuriken"))
        {
           
        }
    }
    
    void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
