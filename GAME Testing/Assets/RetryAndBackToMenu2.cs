using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryAndBackToMenu2 : MonoBehaviour
{
// Start is called before the first frame update

    public void start()
    {

    }

    public void Retry()
    {
        SceneManager.LoadScene("PreStoryRestard");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
