using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed;
    public GameOver gameOver;

	void Update ()
    {
        if (!gameOver.isGameOver())
        {
            Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            transform.Translate(moveInput * speed * Time.deltaTime, Space.World);
        }
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameOver.EndGame();
        }
    }
}
