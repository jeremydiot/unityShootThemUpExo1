using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int healthPoint;
    public GameObject score;
    private void Update()
    {
        if (healthPoint <= 0)
        {
            Destroy(gameObject);
            Counter.increment(10);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Counter.increment(15);
        }
        if (other.CompareTag("Bullet"))
        {
            healthPoint--;
            Destroy(other.gameObject);
        }
        
    }
}
