﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;
    private HealthSystem healthSystemScript;
    void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < bottomBound)
        {
            // Debug.Log("Game Over!");
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }
    }
}
