using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBos : EnemyDamage
{
    public Slider healthBar;
    // Start is called before the first frame update

    [Header ("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    [SerializeField] private AudioClip Uek;
    [SerializeField] private AudioClip mati;
    [SerializeField] private AudioClip sakitboss;
    [SerializeField] private AudioClip Rage;
    [SerializeField] private AudioClip Rage2;
    

    [Header ("iFrames")]
    [SerializeField]private float iFramesDuration;
    [SerializeField]private int numberOfFlashes;
    private SpriteRenderer spriteRend;
    public GameObject Self;
    public GameObject Bazo;
    public GameObject BazoBesar;
    public GameObject BazoBesarGlinding;
    public GameObject PintuRahasia;
    public GameObject RetryAndBackToMenu;
     public GameObject On;

        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHealth;
    }

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
        
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if(currentHealth == 30)
        {
            anim.SetTrigger("rage");
            SoundManagerScript.instance.PlaySound(Rage);
            StartCoroutine(Invunerability());
            Bazo.SetActive(true);
        }
        if(currentHealth == 10)
        {
            anim.SetTrigger("rage2");
            SoundManagerScript.instance.PlaySound(Rage2);
            StartCoroutine(Invunerability());
            BazoBesar.SetActive(false);
            BazoBesarGlinding.SetActive(true);
        }
        if(currentHealth %5 == 0 && currentHealth %10 != 0)
        {
            anim.SetTrigger("hurts");
            SoundManagerScript.instance.PlaySound(sakitboss);
        }
        if(currentHealth > 0)
        {
            anim.SetTrigger("hurt");
            SoundManagerScript.instance.PlaySound(Uek);
        }

        
        if (currentHealth == 0)
        {
            SoundManagerScript.instance.PlaySound(mati);
            PintuRahasia.SetActive(false);
            On.SetActive(true);
            anim.SetTrigger("die");
            Destroy(gameObject,2);
                //Player
            if(GetComponent<PlayerMovement>() != null)
                GetComponent<PlayerMovement>().enabled = false;
                RetryAndBackToMenu.SetActive(true);

                //Enemy
            if(GetComponent<EnemyPatrol>() != null)
                GetComponentInParent<EnemyPatrol>().enabled = false;
                
            if(GetComponent<MeleeEnemy>() != null)
                GetComponent<MeleeEnemy>().enabled = false;
            
            Destroy(Self,1.5f);
        }
    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    private IEnumerator Invunerability()
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);
        for(int i = 0; i < numberOfFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(8, 9, false);
    } 
    
}
