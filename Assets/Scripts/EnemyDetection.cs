using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    [SerializeField] string targetTag;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(targetTag))
        {
            Time.timeScale = 0;
            //Application.Quit();
        }
    }
}
