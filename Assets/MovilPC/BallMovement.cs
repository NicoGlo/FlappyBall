using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Yvelocity = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 movement = rb.velocity;
        Yvelocity = rb.velocity.y;

        //Only usable in Windows
#if (UNITY_EDITOR || UNITY_STANDALONE_WIN)
        //If the spacebar is pressed, the object will receive an impulse through the Y axis
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Yvelocity = 4.5f;
        }

        //Only available in android devices
#elif (UNITY_ANDROID)
            //If the screen is touched, the object will receive an impulse through the Y axis 
            foreach(Touch touch in Input.touches)
            {
                if((Input.GetTouch(0).phase) == TouchPhase.Began)
                {
                    Yvelocity = 4.5f;
                }
            }
        
#endif
        rb.velocity = new Vector3(0, Yvelocity, 0);
    }
}
