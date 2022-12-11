using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
[SerializeField] public int damage;
[SerializeField] private AudioClip GSH;
public SpriteRenderer spriteRenderer;

     void Start()
 {
     this.spriteRenderer = GetComponent<SpriteRenderer>();
 }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("test");
            collision.GetComponent<HealthPlayer>().PlayerTakeDamage(damage);
            
        }
            
            

        if(collision.tag == "Ckia")
        {
            this.spriteRenderer.enabled = true;
            SoundManagerScript.instance.PlaySound(GSH);
        }
    }
}
