using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryAndBack : MonoBehaviour
{
    public void start()
    {

    }

    public void Retry()
    {
        SceneManager.LoadScene("EndlessGame");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Dunia3");
    }
}
