using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerevent : MonoBehaviour
{
    public GameObject sampah1;
    public GameObject Slidder;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            sampah1.SetActive(true);
            Slidder.SetActive(true);
        // if (collision.tag == "pushab")
        //     collision.GetComponent<Cilus>().Start(damage);
    }
    
}
