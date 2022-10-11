using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shield : MonoBehaviour
{
    // Script for summoning the shield when pressing a button.

    // Variables:
    public bool deffending;               // says when we are deffending or not.
    public float timer;                   // a place for us to store the time.
   [SerializeField] GameObject shielding; // the object we are summoning.
    public float cooldownTimer;
    public bool isCooldown;
    public bool canShield;
    private bool shieldUp;
    


    private void Start()
    {
        canShield = true;
        
    }

    private void Update()
    {
        


        if(shieldUp)                     // if the button was pressed.
        {
            timer += Time.deltaTime;       // timer starts
            if (timer >= 5f)               // if timer is equal or greater than 5 seconds
            {
                shieldUp = false;
                shielding.SetActive(false);    // shield game object is not active anymore
                Cooldown();
                cooldownTimer = 0;
                timer = 0;
               
            }
        }

        if (isCooldown)
        {
            cooldownTimer += Time.deltaTime;
            {
                if (cooldownTimer >= 5f)
                {
                    canShield = true;
                }
            }
        }
    }


    public void IsDeffending(bool shield)
    {
       
            shield = true;                       // i dont think this is doing anything but i was afraid of removing it
            
        
    }

    void Cooldown()
    {
        
        canShield = false;
        isCooldown = true;
    }

    

    void OnShield(InputValue value)             // the same explanation from Fire script.
    {
        if (canShield)
        {
            deffending = value.isPressed;
            shielding.SetActive(true);              // shield game object activates
            shieldUp = true;
        }
        


    }
}
