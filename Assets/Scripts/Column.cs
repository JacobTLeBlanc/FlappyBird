using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    // Check if object enters trigger
    private void OnTriggerEnter2D (Collider2D other) 
    {
        // Make sure object is a bird
        if (other.GetComponent<Bird> () != null) {
            GameControl.instance.BirdScored (); // Run Bird Scored function
        }
    }
}
