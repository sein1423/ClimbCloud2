using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb2D;
    float jumpForce = 700f;
    float walkForce = 30f;
    const float MaxWalkSpeed = 2f;
    Animator ani;
    int jump = 0;
    // Start is called before the first frame update\

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        int key = 0;
        if (jump < 1 && Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(Vector2.up * jumpForce);
            ani.SetTrigger("Jump");
            jump++;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }

        float speed = Mathf.Abs(rb2D.velocity.x);
        if (speed < MaxWalkSpeed)
        {
            rb2D.AddForce(Vector2.right * key * walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if(rb2D.velocity.y == 0)
        {
            ani.speed = speed / 2.0f;
            jump = 0;
        }
        else
        {
            ani.speed = 1f;
        }
    }

    
}
