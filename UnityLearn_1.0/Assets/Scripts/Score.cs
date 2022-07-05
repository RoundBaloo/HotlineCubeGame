using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text = (player.position.z / 40).ToString("0");
    }
}
