using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"){
            EventManager.StartDoorEvent(); 
        }
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
