using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] string targetTag;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(targetTag))
        {
            Destroy(collision.gameObject); 
            Destroy(gameObject);           
        }
    }
}
