using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drunk : MonoBehaviour
{
	void Update ()
    {
        GetComponent<Animator>().SetBool("Falling", transform.position.y < 0);

        // ANSWERS for saving malcolm
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

        // GetComponent<Animator>().enabled = false;

        // transform.Rotate(0, 90, 0);
        
        // GetComponent<Rigidbody>().drag = 5000;
    }
}
