// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    private bool open = true;
    private int nextSceneToLoad;
    // Start is called before the first frame update
    public void start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (open == true)
        {
            SceneManager.LoadScene("Dunia2");
        }    
    }

}