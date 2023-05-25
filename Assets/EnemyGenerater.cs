using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerater : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float span = 0.3f;
    float delta = 0;

    void Start()
    {
        
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(EnemyPrefab);
            int px = Random.Range(4, -5);
            go.transform.position=new Vector3(10, px,1);
        }
    }
}
