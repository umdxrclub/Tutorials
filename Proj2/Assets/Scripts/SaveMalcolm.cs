using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMalcolm : MonoBehaviour
{
    // This function runs once, at the beginning of the level.
	void Start ()
    {
        // We're using update instead, because we need to check if the space bar is pressed down every frame, not just the first one.
    }

    // This code runs once per frame.
    void Update()
    {
        /* Let's save Malcolm!
         */
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /* This code will run on any frame that the space button is initially pressed down.
             * 
             * Two basic solutions are commented out below - see if you can figure out others
             */

            // Note: you can just use "transform" as a shortcut instead of "GetComponent<Transform>()".
            // 1: Rotate him 90 degrees
            // transform.Rotate(0, 90, 0);

            // 2: Set his drag really high
            // GetComponent<Rigidbody>().drag = 5000;

            /* Think of other ways to save Malcolm!
             */
        }
    }
}
