using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene1 : MonoBehaviour
{
    public Animator camAnim;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            camAnim.SetBool("cutscene1", true);
            Invoke(nameof(StopCutscene), 1);
        }
    }
    void StopCutscene()
    {
        camAnim.SetBool("cutscene1", false); 
    }
}
