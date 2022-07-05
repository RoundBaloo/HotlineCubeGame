using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public bool gameHasEnded = false;
    float restartDelay = 2.0f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("RestartGame", restartDelay);
        }
    }

    public void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ИЛИ ("имя сцены")
    }
}
