using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharController : MonoBehaviour
{
    GameObject MyChar;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 p1 = transform.position;
        Vector2 p2 = this.MyChar.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.7f;
        float r2 = 0.4f;


    }
}
