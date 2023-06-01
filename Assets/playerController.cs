using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Animator anim;

    Rigidbody2D rigid2D;
    float walkForce = 20.0f;
    float maxWalkSpeed = 0.1f;
    GameObject MyChar;

    void Start()
    {
        anim = GetComponent<Animator>();

        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        float y = Input.GetAxisRaw("Vertical");

        if (y == 0)
        {
            anim.Play("player");
        }
        else if (y == 1)
        {
            anim.Play("playerL");
        }
        else
        {
            anim.Play("playerR");
        }




        int key = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.2f, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.2f, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.2f, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0.2f, 0);
        }
    }
}
