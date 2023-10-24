using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnDelay;
    private int spawnTime;

    void Start()
    {
        StartCoroutine(RandomSpawnTimer());
    }

    IEnumerator SpawnEnemy() 
    {
        while (true)
        {
            Instantiate(enemyPrefab);
            //yield return new WaitForSeconds(spawnDelay);
            yield return new WaitForSeconds(Random.Range(0.3f, 0.9f));
        }
    }

    IEnumerator RandomSpawnTimer()
    {
        while (true) 
        {
            spawnTime = Random.Range(3, 8);
            StartCoroutine("SpawnEnemy");
            yield return new WaitForSeconds(spawnTime);
            StopCoroutine("SpawnEnemy");
            yield return new WaitForSeconds(3);
        }
    }
}
