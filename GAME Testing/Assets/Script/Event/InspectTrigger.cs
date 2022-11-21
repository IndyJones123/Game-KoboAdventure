using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"){
            EventManager.StartInspectEvent(); 
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag != "Player"){
            EventManager.StartInspectEvent(); 
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
