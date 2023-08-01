using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float ForwardMovement = 5;
    public float UpwardMovement = 5;
    public int JumpCount = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
// Creates the inputs for moving on the x axis.
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(ForwardMovement, rb.velocity.y);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-ForwardMovement, rb.velocity.y);
        }
// Creates the input for jumping.
        if (Input.GetKey("w") && JumpCount < 1)
        {
            rb.velocity = new Vector2(rb.velocity.x, UpwardMovement);
            JumpCount++;
        }
    }
}
