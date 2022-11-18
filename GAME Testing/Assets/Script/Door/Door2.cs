// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2 : MonoBehaviour
{
    private bool open = false;
    int prevSceneToLoad;
    // Start is called before the first frame update
    public void start()
    {
        prevSceneToLoad = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (open == true)
        {
            SceneManager.LoadScene("PreStory");
        }    
    }

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.P)) {
            gameObject.GetComponent<Renderer>().enabled = true;
            open = true;
        }
        if (Input.GetKeyUp (KeyCode.P)) {
            gameObject.GetComponent<Renderer>().enabled = false;
            open = false;
        }
    }
}
