using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    Rigidbody body;

	void Start ()
    {
        body = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
        body.AddForce(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"), ForceMode.Force);
	}
}
