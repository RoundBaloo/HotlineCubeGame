using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Manager gameManager;
    private void OnTriggerEnter() 
    {
        gameManager.CompleteLevel();
    }
}
