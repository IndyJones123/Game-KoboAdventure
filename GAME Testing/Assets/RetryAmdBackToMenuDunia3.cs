using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryAmdBackToMenuDunia3 : MonoBehaviour
{
// Start is called before the first frame update

    public void start()
    {

    }

    public void Retry()
    {
        SceneManager.LoadScene("Dunia3");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
