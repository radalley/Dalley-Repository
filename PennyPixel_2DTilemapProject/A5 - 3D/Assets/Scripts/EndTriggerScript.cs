using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriggerScript : MonoBehaviour
{
    private ScoreManager scoreManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        scoreManagerScript = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();

    }

    void OnTriggerEnter(Collider theCollider)
    {
        if (theCollider.CompareTag("Player"))
        {
            
            scoreManagerScript.win=1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
