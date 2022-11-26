using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerbos : MonoBehaviour
{
    public GameObject bos;
    public GameObject BossSlider;
    public GameObject Bazo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"){
            bos.SetActive(true); 
            BossSlider.SetActive(true);
            Bazo.SetActive(true);
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player"){
            Destroy(gameObject);
        }
        
    }
}
