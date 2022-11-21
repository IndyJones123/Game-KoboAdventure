// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    private bool open = false;
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

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.P)) {
            open = true;
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (Input.GetKeyUp (KeyCode.P)) {
            open = false;
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}