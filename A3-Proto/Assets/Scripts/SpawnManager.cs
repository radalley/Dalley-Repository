using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    private float leftBound = -14;
    private float rightbound = 14;
    private float spawnPosZ = 20;
    public bool gameOver = false;

    public HealthSystem healthSystem;

    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();



        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);
        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }
    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!gameOver)
        {
            SpawnRandomPrefab();
            float randomDelay = Random.Range(0.8f, 2.0f);

            yield return new WaitForSeconds(randomDelay);
        }


    }
    void SpawnRandomPrefab()
    {
        int prefaxIndex = Random.Range(0, prefabsToSpawn.Length);

        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightbound), 0, spawnPosZ);

        Instantiate(prefabsToSpawn[prefaxIndex], spawnPos, prefabsToSpawn[prefaxIndex].transform.rotation);
    }
    
}
