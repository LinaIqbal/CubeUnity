using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
// Boolean variable to control the game state (whether it's started or not).
    public bool IsGameStarted = false;

    // Total game time in seconds.
    public float gameDuration = 60.0f;

    // A variable to store the remaining time in the game.
    private float timer;

    // Start is called before the first frame update.
    void Start()
    {
        // Initialize the timer with the total game duration.
        timer = gameDuration;
    }

    // Update is called once per frame.
    void Update()
    {
        if (IsGameStarted)
        {
            // If the game is started, count down the timer by the time that has passed since the last frame.
            timer -= Time.deltaTime;

            // Check if the timer has reached zero.
            if (timer <= 0)
            {
                // If the timer is zero or negative, end the game.
                IsGameStarted = false;
                Debug.Log("Game Over!");
            }
        }
    }

}