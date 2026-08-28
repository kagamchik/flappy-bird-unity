using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour

{
    public GameObject PauseMenu;
    public bool IsPaused;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            

            if (IsPaused)
            {
                ResumeGame();
            }
            else {

                pauseGame();
            }
        }
    }

   public void pauseGame() {
        Time.timeScale =  0;
        PauseMenu.SetActive (true);
        IsPaused = true;
    }

   public void ResumeGame() {
        Time.timeScale = 1;
        IsPaused = false;
        PauseMenu.SetActive(false);
    }

    public void mainMenu() {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
