using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeladder : MonoBehaviour
{
    public GameObject ladder;
    public GameObject floor;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            ladder.SetActive(false);
            floor.SetActive(true);
        }        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Destroy(gameObject);
        }
    }
}
