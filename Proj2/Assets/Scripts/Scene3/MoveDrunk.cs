using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDrunk : MonoBehaviour
{
    // This function runs once, at the beginning of the level.
	void Start ()
    {
        /* Let's save Malcolm!
         *  There are multiple ways to do this.
         *  
         */

        // 1: Rotate 
        // transform.Rotate(0, 90, 0);

        // transform.eulerAngles = new Vector3(0, 90, 0);

        // transform.Translate(0, 0, -1);

        // Vector3 position = transform.position;
        // position.z -= 1;
        // transform.position = position;

        // MEME ANSWERS

        // GetComponent<Rigidbody>().useGravity = false;

        // GetComponent<Rigidbody>().drag = 5000;

        // GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY & RigidbodyConstraints.FreezeRotationZ;

        // transform.Rotate(0, 1, 0);

        // GetComponent<CapsuleCollider>().direction = 2;
        // GetComponent<CapsuleCollider>().height += 5;
    }
}
