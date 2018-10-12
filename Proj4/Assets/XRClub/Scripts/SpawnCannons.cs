using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCannons : MonoBehaviour
{
    public GameObject cannon;

	void Awake()
    {
        for (int i = -15; i < 15; i++)
        {
            if (i % 2 == 0)
                Instantiate(cannon, new Vector3(-14, 0.5f, i), Quaternion.Euler(0, -90, 0));
            else
                Instantiate(cannon, new Vector3(14, 0.5f, i), Quaternion.Euler(0, 90, 0));
        }
	}
}
