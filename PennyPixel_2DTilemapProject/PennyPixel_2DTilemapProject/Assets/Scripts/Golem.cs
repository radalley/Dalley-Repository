using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;
    // Start is called before the first frame update
    protected virtual void Awake()
    {
        base.Awake();
        health = 120;
        GameManager.Instance.score += 2;
    }
    public override void TakeDamage(int amount)
    {

    }

    protected override void Attack(int amount)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
