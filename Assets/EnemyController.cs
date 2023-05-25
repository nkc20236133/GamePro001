using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    GameObject MyChar;

    void Start()
    {
        this.MyChar = GameObject.Find("MyChar");


    }

    void Update()
    {
        transform.Translate( - 0.03f, 0, 0);

        if(transform.position.x<-10.0f)
        {
            Destroy(gameObject);
        }

        //“–‚½‚è”»’è
        Vector2 p1 = transform.position;
        Vector2 p2 = this.MyChar.transform.position;
        Vector2 dir = p1 - p2;
        float d=dir.magnitude;
        float r1 = 0.7f;
        float r2 = 0.4f;

        if(d<r1+r2)
        {
            Destroy(gameObject);
        }
    }
}
