using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannon : MonoBehaviour
{
    public GameObject ammo;
    public Transform barrel;

    float fireRate;
    const float MAX_FIRE_RATE = 0.01f;

    private void Start()
    {
        fireRate = 0.001f;
    }

    // Update is called once per frame
    void Update ()
    {
	    if (Random.value < fireRate)
        {
            Fire();
        }

        fireRate = Mathf.Min(fireRate + 0.001f * Time.deltaTime, MAX_FIRE_RATE);
	}

    public void Fire()
    {
        GameObject cannonBall = Instantiate(ammo, barrel.position, barrel.rotation);

        cannonBall.GetComponent<Rigidbody>().AddForce(barrel.forward * 1000, ForceMode.Impulse);
    }
}
