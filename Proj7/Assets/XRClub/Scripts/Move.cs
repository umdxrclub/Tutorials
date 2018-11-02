using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        transform.Translate(new Vector3(0, 0, Input.GetAxis("Forwards")) * Time.deltaTime * speed);
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // WRITE CODE BELOW HERE ------------------------------
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
        
        anim.SetBool("Moving", Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow));
	}
}
