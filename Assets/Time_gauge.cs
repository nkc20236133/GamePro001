using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timegauge : MonoBehaviour
{
    GameObject Time_gauge;

    void Start()
    {
        this.Time_gauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHp()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    void Update()
    {
        
    }
}
