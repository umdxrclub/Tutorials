using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
	// This function runs once, at the beginning of the simulation.
	void Start ()
    {
        GetComponent<Rigidbody>().maxAngularVelocity = 100;
        //Debug.Log(GetComponent<Rigidbody>().angularVelocity);
	}
}
