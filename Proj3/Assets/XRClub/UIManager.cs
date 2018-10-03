using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text gameOverMessage;
    public Text scoreBoard;

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

    public void AddPoint()
    {
        scoreBoard.text = "" + (int.Parse(scoreBoard.text) + 1);
    }
}
