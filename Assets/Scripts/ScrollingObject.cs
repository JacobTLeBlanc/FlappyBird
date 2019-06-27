using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rb2d; // Get RigidBody2D component

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        // Scroll the ground to simulate movement
        rb2d.velocity = new Vector2 (GameControl.instance.scrollSpeed, 0);
    }

    void Update()
    {
        // If game ends, stop scrolling
        if (GameControl.instance.gameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
