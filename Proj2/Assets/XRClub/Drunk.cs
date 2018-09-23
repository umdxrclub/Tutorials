using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drunk : MonoBehaviour
{
	void Update ()
    {
        GetComponent<Animator>().SetBool("Falling", transform.position.y < 0);

        // ---START CODE---

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Malcolm's brain isn't working very well right now. Help him not die!");

            // MULTIPLE WAYS TO DO THIS:

            transform.Rotate(0, 90, 0);

            // transform.eulerAngles = new Vector3(0, 90, 0);

            // transform.Translate(0, 0, -1);

            // Vector3 position = transform.position;
            // position.z -= 1;
            // transform.position = position;
        }

        // ---END CODE---
	}
}
