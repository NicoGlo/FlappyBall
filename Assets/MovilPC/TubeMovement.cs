using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //The tubes will only move troughout the Z axis after being spawned
        Vector3 velocity = rb.velocity;
        velocity.z = speed;
        rb.velocity = velocity;
        if(transform.localPosition.z < -9)
        {
            gameObject.SetActive(false);
        }
    }
}
