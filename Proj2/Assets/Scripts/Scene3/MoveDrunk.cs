using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDrunk : MonoBehaviour
{
    public float speed;

    // This function runs once, at the beginning of the level.
	void Start ()
    {
        
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

            // Note: you can just use "transform" as a shortcut instead of "GetComponent<Transform>().
            // 1: Rotate him 90 degrees
            // transform.Rotate(0, 90, 0);

            // 2: Set his drag really high
            // GetComponent<Rigidbody>().drag = 5000;
        }


        // transform.eulerAngles = new Vector3(0, 90, 0);

        // transform.Translate(0, 0, -1);

        // Vector3 position = transform.position;
        // position.z -= 1;
        // transform.position = position;

        // MEME ANSWERS

        // GetComponent<Rigidbody>().useGravity = false;

        // GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY & RigidbodyConstraints.FreezeRotationZ;

        // transform.Rotate(0, 1, 0);

        // GetComponent<CapsuleCollider>().direction = 2;
        // GetComponent<CapsuleCollider>().height += 5;
    }
}
