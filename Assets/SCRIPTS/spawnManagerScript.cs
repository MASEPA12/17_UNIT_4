using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManagerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9f;
    public int enemiesInScene;
    public int enemiesPerWave = 1;
    public GameObject[] powerupPrefab;

    void Start()
    {
        SpawnEnemyWave(enemiesPerWave);
    }
    private void Update()
    {
        enemiesInScene = FindObjectsOfType<enemySCRIPT>().Length; //quantitat d'enemics en escena
        if(enemiesInScene <= 0)
        {
            enemiesPerWave++;
            SpawnEnemyWave(enemiesPerWave);
        }
        //si me qued sense eniemics en escena augment es enemics per oleada i llamo a una nuevva oleada
    }
    private Vector3 RandomSpawnPos()
    {
        float randX = Random.Range(-spawnRange, spawnRange);
        float randZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(randX, 0, randZ);
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        int randomIndex = Random.Range(0, powerupPrefab.Length);
        Instantiate(powerupPrefab[randomIndex], RandomSpawnPos(), Quaternion.identity);

        for (int i = 0; i<enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab,RandomSpawnPos(),Quaternion.identity);
        }
    }
}
