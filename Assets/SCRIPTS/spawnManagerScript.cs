using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManagerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9f;

    void Start()
    {
        Instantiate(enemyPrefab, RandomSpawnPos(), Quaternion.identity);
    }

    private Vector3 RandomSpawnPos()
    {
        float randX = Random.Range(-spawnRange, spawnRange);
        float randZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(randX, 0, randZ);
    }
}
