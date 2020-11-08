using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    public GameObject playerGoal;
    private SpawnManagerX spawnManagerScript;
    private ScoreManager scoreManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        spawnManagerScript = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal");
        speed = speed * spawnManagerScript.speedFactor;
        scoreManagerScript = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();

    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * (speed) * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            spawnManagerScript.lossCount++;
            Destroy(gameObject);
        }

    }

}
