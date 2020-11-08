using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    private float spawnRange = 9;
    public int enemyCount;
    public int waveCount =1;

    private ScoreManager scoreManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveCount);
        scoreManagerScript = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();

    }
    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
        Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
    // Update is called once per frame
    void Update()
    {
        scoreManagerScript.waveTot = waveCount;
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if(enemyCount == 0)
        {
            waveCount++;
            SpawnEnemyWave(waveCount);
        }
    }
}
