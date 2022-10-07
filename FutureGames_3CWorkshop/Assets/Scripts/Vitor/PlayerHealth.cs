using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public HealthBar healthBar;
    public Shield shield;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }

    
    public void TakeDamage(float damage)
    {
        if(shield.deffending)
        {
            float shieldProtection = damage /2;
            currentHealth -= (shieldProtection - (damage / 3));
        }
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
      
    }

    public void Heal(int heal)
    {
        currentHealth = +heal;
        healthBar.SetHealth(currentHealth);
    }


}
