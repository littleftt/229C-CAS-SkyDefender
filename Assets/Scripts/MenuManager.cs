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
    }

    public void Back()
    {
        creditsScene.SetActive(false);
    }

   public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
   public void QuitGame()
    {
        Application.Quit();
    }
}
