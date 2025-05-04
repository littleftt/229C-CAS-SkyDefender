using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    [SerializeField] string targetTag;
    public GameObject gameOverScreen;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(targetTag))
        {

            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
            
        }
    }
}
