using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryAndBackToMenu : MonoBehaviour
{

    // Start is called before the first frame update

    public void start()
    {

    }

    public void Retry()
    {
        SceneManager.LoadScene("Dunia2");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
