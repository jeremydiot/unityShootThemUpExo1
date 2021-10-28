using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShell : MonoBehaviour
{
    public int healthPoint = 2;
    private Vector3 initialPos;
    private void Start()
    {
        initialPos = transform.position;
    }
    private void Update()
    {
        if (healthPoint <= 0)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < initialPos.x * -1)
        {
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            healthPoint--;
            Destroy(other.gameObject);
        }
       
    }
}
