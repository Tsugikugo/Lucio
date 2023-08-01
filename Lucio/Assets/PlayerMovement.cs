using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float ForwardMovement = 5;
    public float UpwardMovement = 5;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(ForwardMovement, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-ForwardMovement, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector2(0, UpwardMovement);
        }
    }
}
