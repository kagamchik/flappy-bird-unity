using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    public GameObject StartMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void StartGame() {
        SceneManager.LoadScene("SampleScene");
    }



    public void QuitGame() {
        Debug.Log("pressed!!!");
        Application.Quit();

    }

}
