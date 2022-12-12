using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    [SerializeField] int playerScore = 0;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject gameOverScreen;

    public void addScore(int scoreToAdd)
    {

        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }
}
