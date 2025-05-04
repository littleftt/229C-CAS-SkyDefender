using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] string targetTag;
    [SerializeField] float lifetime;
    

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(targetTag))
        {
            ScoreManager.instance.AddPoint();
            Destroy(collision.gameObject); 
            Destroy(gameObject);           
        }
    }
}
