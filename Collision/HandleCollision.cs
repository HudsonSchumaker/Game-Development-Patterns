using UnityEngine;

// Hudson Schumaker
public class HandleCollision : MonoBehaviour 
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        // check what is necessary
    }
    
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            transform.parent = collision.gameObject.transform;
            return;
        }

        if (collision.gameObject.tag == "Spike")
        {
            this.DoDamage();
        }
    }

   
}
