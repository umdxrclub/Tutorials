using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text gameOverMessage;

    bool gameOver;

	void Update ()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.Space))
        {
            gameOver = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public bool isGameOver()
    {
        return gameOver;
    }

    public void EndGame()
    {
        gameOverMessage.gameObject.SetActive(true);
        gameOver = true;
    }
}
