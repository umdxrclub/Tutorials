using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime;
    public float damage;
    float time;
	
	// Update is called once per frame
	void Update ()
    {
        time += Time.deltaTime;

        if (time > lifetime)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Player>() != null)
        {
            collision.gameObject.GetComponent<Player>().Damage(damage);
            Destroy(gameObject);
        }
    }
}
