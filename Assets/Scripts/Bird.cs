using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    
    private float upForce = 200f;
    private bool isDead = false; // Check if dead
    private Rigidbody2D rb2d; // RigidBody component of bird
    private Animator anim; // Animation object

    void Start()
    {
        // Get component to reference
        rb2d = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false) 
        {
            if (Input.GetMouseButtonDown (0))
            {
                rb2d.velocity = Vector2.zero; // Reset vel to 0
                rb2d.AddForce(new Vector2(0, upForce)); // Add vertical force
                anim.SetTrigger ("Flap"); // Show flap animation on input
            }
        }
    }

    // Check if bird collides with anything
    void OnCollisionEnter2D ()
    {
        rb2d.velocity = Vector2.zero; // reset velocity on death
        isDead = true; // bird is dead
        anim.SetTrigger("Die"); // Show "Die" animation
        GameControl.instance.BirdDied (); // Run bird died function of game control
    }
}
