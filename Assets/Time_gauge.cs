using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timegauge : MonoBehaviour
{
    GameObject Image;


    public Image UIobj;
    public bool roop;
    public float countTime = 100.0f;

    void Start()
    {
        this.Image = GameObject.Find("Image");

    }

    void Update()
    {
        if(roop)
        {
            UIobj.fillAmount -= 1.0f / countTime * Time.deltaTime;
        }
    }

    public void HPdelete()
    {
        this.Image.GetComponent<Image>().fillAmount -= 0.1f;
    }

}
