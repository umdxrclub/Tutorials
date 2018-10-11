using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public List<GameObject> characters;
    public Transform characterBase;
    int characterIndex;

    private void Start()
    {
        CharacterData.character = characters[0];
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.Q))
        {
            PrevCharacter();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            NextCharacter();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            NextScreen();
        }
	}

    public void NextCharacter()
    {
        Destroy(characterBase.GetChild(0).gameObject);

        characterIndex = characterIndex < characters.Count - 1 ? characterIndex + 1 : 0;

        Instantiate(characters[characterIndex], characterBase);
        CharacterData.character = characters[characterIndex];
    }

    public void PrevCharacter()
    {
        Destroy(characterBase.GetChild(0).gameObject);

        characterIndex = characterIndex > 0 ? characterIndex - 1 : characters.Count - 1;

        Instantiate(characters[characterIndex], characterBase);
        CharacterData.character = characters[characterIndex];
    }

    public void NextScreen()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void SetRotation(float rotation)
    {
        Vector3 rot = transform.eulerAngles;
        rot.y = 360 - rotation;
        transform.eulerAngles = rot;
    }
}
