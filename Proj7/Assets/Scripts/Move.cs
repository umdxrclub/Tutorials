using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(movement * Time.deltaTime * speed);
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // WRITE CODE BELOW HERE ------------------------------
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }

        anim.SetFloat("Speed", movement.magnitude);
	}
}
