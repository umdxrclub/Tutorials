using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartXR : MonoBehaviour
{
    public Transform seat;
    public float speed;
    public Transform player;

    [HideInInspector]
    public bool controlled;
    public float turnSpeed;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        turnSpeed = 1;
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!controlled && Vector3.Distance(seat.position, player.position) < 3)
            {
                EnterCart();
            }
            else if (controlled)
            {
                ExitCart();
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed *= 3;
            turnSpeed /= 4;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed /= 3;
            turnSpeed *= 4;
        }

        if (controlled)
        {
            transform.Translate(new Vector3(0, 0, Input.GetAxis("Forwards")) * Time.deltaTime * speed);
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * turnSpeed, 0));
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            if (Vector3.Distance(seat.position, player.position) > 1)
            {
                ExitCart();
            }


            // WRITE CODE HERE -----------------
            anim.SetBool("Moving", Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow));
        }
    }

    void EnterCart()
    {
        player.position = seat.position;
        player.rotation = seat.rotation;

        controlled = true;
        player.SetParent(seat);
        player.GetComponent<Move>().enabled = false;
        player.GetComponent<Animator>().SetBool("Moving", false);
    }

    void ExitCart()
    {
        controlled = false;
        player.SetParent(null);
        player.GetComponent<Move>().enabled = true;
    }
}
