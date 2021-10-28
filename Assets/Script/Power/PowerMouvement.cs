using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerMouvement : MonoBehaviour
{
    public float speed = 10;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
