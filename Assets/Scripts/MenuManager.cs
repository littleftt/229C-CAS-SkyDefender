using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject creditsScene;

   public void LoadGame()
    {
        SceneManager.LoadScene("MainGame");
        Time.timeScale = 1;
    }
    public void LoadCredits()
    {
        creditsScene.SetActive(true);
        Time.timeScale = 0;
    }

    public void Back()
    {
        creditsScene.SetActive(false);
        Time.timeScale = 1;
    }

   public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
   public void QuitGame()
    {
        Application.Quit();
    }
}
