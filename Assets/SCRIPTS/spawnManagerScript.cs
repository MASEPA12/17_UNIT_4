using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManagerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9f;
    public int enemiesInScene;
    public int enemiesPerWave = 1;
    public GameObject powerupPrefab;

    void Start()
    {
        SpawnEnemyWave(3);
    }

    private Vector3 RandomSpawnPos()
    {
        float randX = Random.Range(-spawnRange, spawnRange);
        float randZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(randX, 0, randZ);
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i<enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab,RandomSpawnPos(),Quaternion.identity);
        }
    }
}
