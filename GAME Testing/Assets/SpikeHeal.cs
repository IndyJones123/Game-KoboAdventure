using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeHeal : MonoBehaviour
{
    [SerializeField] public int heal;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("test");
            collision.GetComponent<HealthPlayer>().PlayerTakeHeal(heal);
            
        }
    }
}

