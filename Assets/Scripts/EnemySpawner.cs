using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    public float spawnInterval = 5f;
    private float spawnTimer = 0f;

    private float intervalDecreaseTime = 10f;
    private float intervalDecreaseAmount = 0.5f;
    private float minSpawnInterval = 1f;
    private float gameTimer = 0f;

    void Update()
    {
        spawnTimer += Time.deltaTime;
        gameTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }

      
        if (gameTimer >= intervalDecreaseTime)
        {
            gameTimer = 0f;

            if (spawnInterval > minSpawnInterval)
            {
                spawnInterval -= intervalDecreaseAmount;

               
                if (spawnInterval < minSpawnInterval)
                    spawnInterval = minSpawnInterval;

            }
        }
    }

    void SpawnEnemy()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[index];

        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}
