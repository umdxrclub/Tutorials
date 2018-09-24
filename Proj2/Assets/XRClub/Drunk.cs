using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drunk : MonoBehaviour
{
	void Update ()
    {
        GetComponent<Animator>().SetBool("Falling", transform.position.y < 0);
    }
}
