using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerFearRabbits : MonoBehaviour
{
    public GameObject rabbitgendong;
    public GameObject rabbitfear;
    public GameObject text;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            rabbitgendong.SetActive(false);
            rabbitfear.SetActive(true);
            text.SetActive(true);
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
