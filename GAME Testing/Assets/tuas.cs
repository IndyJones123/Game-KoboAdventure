using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuas : MonoBehaviour
{
    public GameObject Box1;
    public GameObject Box2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Box1.SetActive(true);
            Box2.SetActive(false);
            Destroy(gameObject);
        }
    }
}
