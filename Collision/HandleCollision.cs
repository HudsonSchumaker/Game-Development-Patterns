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
            if (LayerMask.LayerToName(collision.gameObject.layer).Equals("Deep"))
            {
                this.playerController.SetDrag();
            }
        }
    }
    
    void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
