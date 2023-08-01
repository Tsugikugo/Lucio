using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            playerMovement.JumpCount = 0;
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            gameManager.GameOver();
        }
    }
}
