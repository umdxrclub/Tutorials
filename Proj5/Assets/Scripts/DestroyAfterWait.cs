using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterWait : MonoBehaviour {

    public float lifetime = 5.0f;

    private float counter;

	void Update () {
        counter += Time.deltaTime;
        if (counter >= lifetime)
        {
            Destroy(gameObject);
        }

	}
}
