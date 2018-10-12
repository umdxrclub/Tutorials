using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public List<GameObject> characters;
    public List<GameObject> items;
    public Transform characterBase;
    int characterIndex;
    int leftHandIndex;

    private void Start()
    {
        CharacterData.character = characters[0];
    }

    public void NextCharacter()
    {
        Destroy(characterBase.GetChild(0).gameObject);

        characterIndex = characterIndex < characters.Count - 1 ? characterIndex + 1 : 0;

        CharacterData.character = characters[characterIndex];
        GameObject player = Instantiate(characters[characterIndex], characterBase);

        if (CharacterData.leftHand != null)
        {
            Transform leftHand = FindRecursive(player.transform, player.GetComponent<LeftHand>().handName);
            Instantiate(CharacterData.leftHand, leftHand);
        }
    }

    public void PrevCharacter()
    {
        Destroy(characterBase.GetChild(0).gameObject);

        characterIndex = characterIndex > 0 ? characterIndex - 1 : characters.Count - 1;

        CharacterData.character = characters[characterIndex];
        GameObject player = Instantiate(characters[characterIndex], characterBase);

        if (CharacterData.leftHand != null)
        {
            Transform leftHand = FindRecursive(player.transform, player.GetComponent<LeftHand>().handName);
            Instantiate(CharacterData.leftHand, leftHand);
        }
    }

    public void NextItem()
    {
        string handName = characterBase.GetChild(0).GetComponent<LeftHand>().handName;
        Transform hand = FindRecursive(characterBase.GetChild(0), handName);
        Transform item = hand.Find(items[leftHandIndex].name + "(Clone)");

        if (item != null)
            Destroy(item.gameObject);

        leftHandIndex = leftHandIndex < items.Count - 1 ? leftHandIndex + 1 : 0;

        Instantiate(items[leftHandIndex], hand);
        CharacterData.leftHand = items[leftHandIndex];
    }

    public void PrevItem()
    {
        string handName = characterBase.GetChild(0).GetComponent<LeftHand>().handName;
        Transform hand = FindRecursive(characterBase.GetChild(0), handName);
        Transform item = hand.Find(items[leftHandIndex].name + "(Clone)");

        if (item != null)
            Destroy(item.gameObject);

        leftHandIndex = leftHandIndex > 0 ? leftHandIndex - 1 : items.Count - 1;

        Instantiate(items[leftHandIndex], hand);
        CharacterData.leftHand = items[leftHandIndex];
    }

    public void Play()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void SetRotation(float rotation)
    {
        Vector3 rot = transform.eulerAngles;
        rot.y = 360 - rotation;
        transform.eulerAngles = rot;
    }

    public static Transform FindRecursive(Transform current, string name)
    {
        Transform child = current.Find(name);

        if (child == null)
        {
            for (int i = 0; i < current.childCount; i++)
            {
                child = FindRecursive(current.GetChild(i), name);

                if (child != null)
                {
                    return child;
                }
            }

            return null;
        }
        else
            return child;
    }
}
