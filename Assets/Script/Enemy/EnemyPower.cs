using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPower : MonoBehaviour
{
    
    public GameObject powerShell;
    public GameObject powerWall;
    public Vector3 wallOffset;

    public int precision = 10;
    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(0, precision);

        if (randomNumber == 0)
        {
            Instantiate(powerShell, transform.position, Quaternion.identity);

        }else if (randomNumber == 1)
        {
            Instantiate(powerWall, transform.position+wallOffset, Quaternion.identity);

        }
    }
}
