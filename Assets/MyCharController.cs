using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float walkForce = 20.0f;
    float maxWalkSpeed = 0.1f;
    GameObject MyChar;

    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        int key = 0;
        if (Input.GetKey(KeyCode.UpArrow)) key = 1;
        if (Input.GetKey(KeyCode.DownArrow)) key = -1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;


        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        float speedy = Mathf.Abs(this.rigid2D.velocity.y);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
        if (speedy < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

    }
}
