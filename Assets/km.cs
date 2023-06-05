using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class km : MonoBehaviour
{
    GameObject timerText;
    float time = 000000.0f;
    

    void Start()
    {
        this.timerText = GameObject.Find("Time");
    }

    void Update()
    {
        this.time += Time.deltaTime*60;
        this.timerText.GetComponent<TextMeshProUGUI>().text =
            this.time.ToString("f0");
    }
}
