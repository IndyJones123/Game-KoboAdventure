using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public GameObject GameOver;
    [SerializeField] public float maxHealth;
    public float currentHealth;
    private bool dead;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        dead = false;
    }

    void Update()
    {
        if(dead==true)
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    public void PlayerTakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        if(currentHealth == 0)
        {
            GameOver.SetActive(true);
            dead = true;
        }
    }

    public void PlayerTakeHeal(int heal)
    {
        
        if(currentHealth < 3)
        {
            currentHealth = currentHealth + heal;
        }
    }
}
