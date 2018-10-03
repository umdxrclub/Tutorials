using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickups : MonoBehaviour
{
    public GameObject pickup;
    public float spawnTime;

    float time;

	void Update ()
    {
        time += Time.deltaTime;

        if (time > spawnTime)
        {
            int randX = Mathf.FloorToInt(Random.Range(-2, 3)) * 4;
            int randZ = Mathf.FloorToInt(Random.Range(-2, 3)) * 4;

            Instantiate(pickup, new Vector3(randX, 1, randZ), Quaternion.Euler(Vector3.zero));
            time = 0;
        }
	}
}
