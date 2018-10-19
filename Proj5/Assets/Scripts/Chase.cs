using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

    public Transform plane;
    public float speed = 10.0f;
    public bool exploded;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.LookAt(plane);
        rb.velocity = (plane.transform.position - transform.position).normalized * speed;
    }

    // Update is called once per frame
    void Update () {

	}
}
