using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //private float spawnInterval = Random.Range(3f,5f);

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        StartCoroutine(SpawnRandomBallWithCoroutine());
    }
    IEnumerator SpawnRandomBallWithCoroutine()
    {
       yield return new WaitForSeconds(1f);

        while(spawnLimitXLeft==-22)
        {
            SpawnRandomBall();
            float randomDelay = Random.Range(3f, 5f);

            yield return new WaitForSeconds(randomDelay);

        }

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int ballRange = Random.Range(0, 2);
        Instantiate(ballPrefabs[ballRange], spawnPos, ballPrefabs[ballRange].transform.rotation);
    }

}
