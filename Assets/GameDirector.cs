using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    float time = 100.0f;

    void Start()
    {
        this.timerText = GameObject.Find("Time");
    }

    void Update()
    {
        this.time -= Time.deltaTime;

    }
}
