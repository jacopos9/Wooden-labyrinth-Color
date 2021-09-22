using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject completeLevel; // <--- wip

    public void CompleteLevel()
    {
        completeLevel.SetActive(true);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void GoToReadMe()
    {
        SceneManager.LoadScene(2);
    }  
}
