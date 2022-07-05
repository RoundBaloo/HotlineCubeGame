using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI gameOverText;
    void Update()
    {
        if (FindObjectOfType<Manager>().gameHasEnded)
        gameOverText.text = "GAME OVER";
    }
}
