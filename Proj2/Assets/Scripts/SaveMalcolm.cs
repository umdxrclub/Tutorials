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


        if (transform.position.x < -5)
        {
            transform.Rotate(0, 180, 0);
        }

        Debug.Log(transform.forward);
        Debug.Log(transform.up);
        Debug.Log(transform.right);

        // This code will run on any frame that the space button is initially pressed down.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /* Use Malcolm's components to try and save him! Malcolm has a Transform, Animator, Rigidbody, and a Capsule Collider.
             * You can find the member variables of each of these components using the scripting reference - https://docs.unity3d.com/ScriptReference/index.html
             * 
             * Remember, you can get any of Malcolm's components using GetComponent<T>(), where T is the component name.
             */

            Debug.Log("Malcolm's brain is currently unavailable. Please help him!");

            // ----- INSERT CODE HERE -----
            //GetComponent<Transform>().position = new Vector3(-3, 0, -1.5f);

            //Vector3 oldPos = GetComponent<Transform>().position;
            //oldPos.x = 4;
            //GetComponent<Transform>().eulerAngles = new Vector3(0, 90, 0);

            //transform.Translate(1, 0, 0);
            //transform.Rotate(0, 90, 0);

            Debug.Log(transform.position);
            Debug.Log(transform.rotation);
            Debug.Log(transform.eulerAngles);

        }
    }
}
