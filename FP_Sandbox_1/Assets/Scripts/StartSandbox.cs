using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartSandbox : MonoBehaviour
{
    public void EnterSandbox()
    {
        SceneManager.LoadScene("MainLevel");
    }
}
