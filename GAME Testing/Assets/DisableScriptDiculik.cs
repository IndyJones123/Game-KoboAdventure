using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableScriptDiculik : MonoBehaviour
{
    public ScriptDiculik script;
    public GameObject Background;
    private bool culik;
    // Start is called before the first frame update
    void Start()
    {
        culik = false;
        
    }

    void Update()
    {
        if(culik==true)
        {
            script.enabled=false;
            Background.SetActive(false);
        }  
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            culik=true;
        }
            
    }
}
