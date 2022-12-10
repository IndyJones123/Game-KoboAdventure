using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
[SerializeField] public int damage;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            Debug.Log("test");
            collision.GetComponent<HealthPlayer>().PlayerTakeDamage(damage);
    }
}
