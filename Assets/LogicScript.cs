using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject startScreen;
    public GameObject bottleParts;
    public GameObject bottle;

    [ContextMenu("Add score")]
    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void BreakBottle()
    {
        Instantiate(bottleParts, bottle.transform.position, transform.rotation);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
