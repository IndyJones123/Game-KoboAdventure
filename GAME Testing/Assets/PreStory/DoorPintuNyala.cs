using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPintuNyala : MonoBehaviour
{
    public GameObject portal;
    private bool open = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

                portal.SetActive(true); 
        }    
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
                portal.SetActive(false); 
        }    
    }
}
