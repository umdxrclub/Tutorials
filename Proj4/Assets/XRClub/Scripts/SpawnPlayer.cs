using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
	void Awake()
    {
	    if (CharacterData.character != null)
        {
            GameObject player = Instantiate(CharacterData.character, new Vector3(0, 0.5f, 0), Quaternion.Euler(Vector3.zero));

            Transform leftHand = CharacterSelect.FindRecursive(player.transform, player.GetComponent<LeftHand>().handName);
            Instantiate(CharacterData.leftHand, leftHand);

            player.AddComponent<Player>();
        }
        else
        {
            Debug.Log("Please set a character.");
        }
	}
}
