using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject completeLevel;

    public void CompleteLevel()
    {
        completeLevel.SetActive(true);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
