using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWall : MonoBehaviour
{
    private Vector3 initialPos;
    private void Start()
    {
        initialPos = transform.position;
    }


    void Update()
    {
        if (transform.position.x < initialPos.x * -1)
        {
            Destroy(gameObject);
        }
    }
}
