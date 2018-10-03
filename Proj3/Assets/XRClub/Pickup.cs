using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float duration;

    float time;
	
	void Update ()
    {
        time += Time.deltaTime;
	    if (time > duration)
        {
            Destroy(gameObject);
        }
	}
}
