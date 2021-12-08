using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : EnemyBullet
{
    public float maxhealth = 100;
    public float currenthealth;

    // Start is called before the first frame update
    void Start()
    {
        maxhealth = currenthealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;

        if (maxhealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
