using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider; // Box Collider component
    private float groundHorizontalLength;

    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D> (); // Get Box Collider
        groundHorizontalLength = groundCollider.size.x; // Get size of collider
    }

    // Update is called once per frame
    void Update()
    {
        // Once the background scrolls its whole length call reposition bg
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground ();
        }
    }

    private void RepositionBackground()
    {
        // Reposition next to other bg to create endless effect
        Vector2 groundOffset = new Vector2 (groundHorizontalLength * 2f, 0);
        transform.position = (Vector2) transform.position + groundOffset;
    }
}
