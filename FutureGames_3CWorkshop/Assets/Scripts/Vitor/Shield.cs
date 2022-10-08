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
    

    private void Update()
    {
        if(deffending)                     // if the button was pressed.
        {
            timer += Time.deltaTime;       // timer starts
            if (timer >= 5f)               // if timer is equal or greater than 5 seconds
            {
                shielding.SetActive(false);    // shield game object is not active anymore
                timer = 0;                     // timer goes back to 0 (otherwise it would keep counting forever)
            }
        }
    }


    public void IsDeffending(bool shield)
    {
       
            shield = true;                       // i dont think this is doing anything but i was afraid of removing it
            
        
    }

    

    void OnShield(InputValue value)             // the same explanation from Fire script.
    {
       deffending = value.isPressed;
        shielding.SetActive(true);              // shield game object activates

        


    }
}
