using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : EnemyDamage
{
    [Header ("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    public Slider healthBar;
    [SerializeField] private AudioClip Sakit1;
    [SerializeField] private AudioClip Sakit2;
    [SerializeField] private AudioClip mati;

    [Header ("iFrames")]
    [SerializeField]private float iFramesDuration;
    [SerializeField]private int numberOfFlashes;

    private void Update()
    {
        healthBar.value = currentHealth;
    }


    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
        }


        if (currentHealth % 5 == 0)
        {
            SoundManagerScript.instance.PlaySound(Sakit1);
        }
        if (currentHealth % 5 == 3)
        {
            SoundManagerScript.instance.PlaySound(Sakit2);
        }
        if (currentHealth == 0)
            {
                SoundManagerScript.instance.PlaySound(mati);
                anim.SetTrigger("die");
                //Player
                if(GetComponent<PlayerMovement>() != null)
                    GetComponent<PlayerMovement>().enabled = false;

                //Enemy
                if(GetComponent<EnemyPatrol>() != null)
                    GetComponentInParent<EnemyPatrol>().enabled = false;
                    
                if(GetComponent<MeleeEnemy>() != null)
                    GetComponent<MeleeEnemy>().enabled = false;


            }
        }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
    
}
