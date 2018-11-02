using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Malcolm : MonoBehaviour
{
    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Crouching", !anim.GetBool("Crouching"));
        }

        anim.SetBool("Moving", Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow));
    }
}
