using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remote : MonoBehaviour
{
    /* Code already exists to check if one of the buttons is pressed.
     * Your job now is two parts.
     * 
     * First, add a reference to the Screen object so we can call its methods.
     * Second, write code in the Update() function to actually call those methods.
     */

    public Button playButton;
    public Button pauseButton;
    public Button loopButton;
    public Button resetButton;

    // ----- INSERT CODE HERE -----

    void Update ()
    {
		if (playButton.isPressedDown())
        {
            Debug.Log("Play button pressed");
            // ----- INSERT CODE HERE -----
        }
        else if (pauseButton.isPressedDown())
        {
            Debug.Log("Pause button pressed");
            // ----- INSERT CODE HERE -----
        }
        else if (loopButton.isPressedDown())
        {
            Debug.Log("Loop button pressed");
            // ----- INSERT CODE HERE -----
        }
        else if (resetButton.isPressedDown())
        {
            Debug.Log("Reset button pressed");
            // ----- INSERT CODE HERE -----
        }
    }
}
