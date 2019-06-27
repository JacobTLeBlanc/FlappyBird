using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public Text scoreText; // Score UI
    public bool gameOver = false;
    public float scrollSpeed = -1.5f; // Accesible to all scrolling objects
    private int score = 0;

    void Awake()
    {
        // Make sure there is only one instance of game control
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // On game over check for input
        if (gameOver == true && Input.GetMouseButtonDown(0)) 
        {
            // Restart current scene
            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
        }
    }

    // What to do when player scores
    public void BirdScored() 
    {
        if (gameOver) // Check if game over 
        {
            return;
        }
        score++; // Add 1 to score
        scoreText.text = "Score: " + score.ToString (); // Update UI
    }

    // What to do when bird dies
    public void BirdDied() {

        // Show game over text
        gameOverText.SetActive (true);
        // Set game over to true
        gameOver = true;
    }
}
