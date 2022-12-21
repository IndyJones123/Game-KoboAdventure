using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] public float damage;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            collision.GetComponent<Health>().TakeDamage(damage);
        if (collision.tag == "Boss")
            collision.GetComponent<HealthBos>().TakeDamage(damage);
    }
}
