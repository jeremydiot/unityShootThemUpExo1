using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int healthPoint;
    public int healthPointMax;
    
    GUIStyle style = new GUIStyle();
    private float height;
    private float width;
    
    


    private void Start()
    {
        style.fontSize = 40;
        style.fontStyle = FontStyle.Bold;
        style.alignment = TextAnchor.MiddleCenter;
        style.normal.textColor = Color.white;
        
        healthPointMax = healthPoint;
        
        var p1 = gameObject.transform.TransformPoint(0, 0, 0);
        var p2 = gameObject.transform.TransformPoint(1, 1, 0);
        width= p2.x - p1.x;
        height= p2.y - p1.y;
    }

    private void Update()
    {
        if (healthPoint <= 0)
        {
            //Destroy(gameObject);
            Counter.decrement(20);
            healthPoint = healthPointMax;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BulletEnemy"))
        {
            healthPoint--;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("WallEnemy"))
        {
            Destroy(other.gameObject);
            Counter.decrement(20);
            healthPoint = healthPointMax;
        }
        if (other.CompareTag("ShellEnemy"))
        {
            Destroy(other.gameObject);
            Counter.decrement(20);
            healthPoint = healthPointMax;
        }
        
    }
    
    void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        GUI.Label(new Rect(position.x, Screen.height - position.y, width, height), healthPoint.ToString(), style);
    }
 
}
