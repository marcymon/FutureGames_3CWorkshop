using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Script to deal with everything related to the player health.

    public float maxHealth = 100f;
    public float currentHealth;
    public HealthBar healthBar;
    public Shield shield;

    void Start()
    {
        currentHealth = maxHealth;                        // we start with full hp
        healthBar.SetMaxHealth(maxHealth);                // attach this information on the health bar
        
    }


    private void Update()
    {
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }





    // all those methods work the same way: 
    // - Its made it public so other scripts could access it.
    // - It has an informative name, so we understand what it does.
    // - It has parameters inside the ( ) because we expect the other scripts who access it to inform us the value of the variable. For example: We could have
    // more than one enemy but both gives a different amount of damage. instead of creating more than one method, we can simply inform how much damage it will give
    // on their own scripts.
    // - Inside the methods, we describe what we want to do with the information we receive.

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;                          // decrease the hp by the amount the enemy informed
        healthBar.SetHealth(currentHealth);               // attach this information on the health bar

    }

    public void TakeShieldDamage(float shieldDamage)
    {
        currentHealth -= shieldDamage;                    // decrease the hp by the amount informed by the shield
        healthBar.SetHealth(currentHealth);               // attach this information on the health bar
    }

    public void Heal(int heal)
    {
        currentHealth += heal;                           // increase hp
        healthBar.SetHealth(currentHealth);              // attach this information on the health bar
    }


}
