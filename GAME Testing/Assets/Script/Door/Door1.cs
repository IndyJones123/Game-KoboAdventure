// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    private int nextSceneToLoad;
    // Start is called before the first frame update
    public void start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 3;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
