using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionRaycastTEST : MonoBehaviour {

    public GameObject explosion;
    public Camera MainCamera;
    public float dist = 1000.0f;

    private RaycastHit hit;


	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("MOUSE BUTTON");
            if (Physics.Raycast(MainCamera.ScreenPointToRay(Input.mousePosition), out hit, dist))
            {
                Instantiate(explosion, hit.point, Quaternion.identity);
            }
        }
	}
}
