using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public float  border = 15;

public int PlayerScore;
public Text ScoreText;
public GameObject gameOverScreen;


 public void addScore(int scoreToAdd)
    {
        PlayerScore = PlayerScore + scoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }



    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        
    }
}
