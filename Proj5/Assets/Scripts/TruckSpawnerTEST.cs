using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckSpawnerTEST : MonoBehaviour {

    public GameObject Truck;
    public Transform plane;

    public float spawnTime;

    private float timer;

	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            GameObject truck = Instantiate(Truck, transform.position, Quaternion.identity);
            truck.GetComponent<Chase>().plane = plane;
            timer = 0;
        }
	}
}
