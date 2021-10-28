using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMouvement : MonoBehaviour
{
    public float speed = 10;
    private Vector3 initialPos;
    private void Start()
    {
        initialPos = transform.position;
    }
    
    private void Update()
    {

        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < initialPos.x * -1)
        {
            Destroy(gameObject);
            Counter.decrement(10);
        }
    }
}
