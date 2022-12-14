using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    [SerializeField] int playerScore = 0;
    [SerializeField] Text scoreText;
    public GameObject gameOverScreen;
    [SerializeField] AudioSource pointSFX;
    [SerializeField] AudioSource deathSFX;

    public void addScore(int scoreToAdd)
    {

        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
        pointSFX.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
        deathSFX.Play();
    }

    public int getScore() {
        return playerScore;
    }
}
