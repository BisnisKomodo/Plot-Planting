using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryManager : MonoBehaviour
{
    public void StartGamePlay()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void StartMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}