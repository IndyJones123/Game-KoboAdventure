using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampahOrganikTrigger : MonoBehaviour
{
    public bool damage;
    public GameObject sampah1;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Penculik")
            sampah1.GetComponent<Cilus>().Check(damage);
        if (collision.tag == "Penculik2")
            sampah1.GetComponent<Cilus2>().Check(damage);
        // if (collision.tag == "pushab")
        //     collision.GetComponent<Cilus>().Start(damage);
    }
    
}
