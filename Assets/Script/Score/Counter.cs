using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    
    GUIStyle style = new GUIStyle();
    private float height;
    private float width;
    private static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        style.fontSize = 40;
        style.fontStyle = FontStyle.Bold;
        style.alignment = TextAnchor.MiddleLeft;
        style.normal.textColor = Color.white;

        var p1 = gameObject.transform.TransformPoint(0, 0, 0);
        var p2 = gameObject.transform.TransformPoint(1, 1, 0);
        width= p2.x - p1.x;
        height= p2.y - p1.y;
    }

    public static int increment(int value)
    {
        score = score + value;
        return score;
    }

    public static int decrement(int value)
    {
        score = score - value;
        return score;
    }
    
    void OnGUI()
    {
        var position = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        GUI.Label(new Rect(position.x, Screen.height - position.y, width, height), "Score : "+Counter.score.ToString(), style);
    }
}
