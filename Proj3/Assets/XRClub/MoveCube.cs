using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed;
    public UIManager manager;
    
	void Update ()
    {
        if (!manager.isGameOver())
        {
            Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            transform.Translate(moveInput * speed * Time.deltaTime, Space.World);
        }
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            manager.EndGame();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup") && !manager.isGameOver())
        {
            Destroy(other.gameObject);
            manager.AddPoint();
        }
    }
}
