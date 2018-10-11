using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
	void Awake()
    {
	    if (CharacterData.character != null)
        {
            GameObject GO = Instantiate(CharacterData.character, new Vector3(0, 0.5f, 0), Quaternion.Euler(Vector3.zero));
            GO.AddComponent<Player>();
        }
        else
        {
            Debug.Log("Please set a character.");
        }
	}
}
