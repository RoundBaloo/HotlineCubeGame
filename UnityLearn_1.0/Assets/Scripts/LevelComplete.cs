using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        // вызывает 2-ю сцену
        SceneManager.LoadScene("EndScreen"); // ИЛИ ("имя сцены") ИЛИ SceneManager.LoadScene(SceneManager.GetActiveScene().name) ИЛИ SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1)
    }
}
