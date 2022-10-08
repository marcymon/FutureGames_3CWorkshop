using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;               // we need to write this here if we want to "speak" to the new input system

public class Fire : MonoBehaviour
{
   // This script is made for the player to shoot.

    //Variables:
    private bool fire;                                    // checks if its firing or not (we could use this on the update if we wanted something more complexed).
    [SerializeField] private GameObject bullet;         // the bullet / projectile prefab.
    [SerializeField] private Transform gunPosition;            // the position where the bullet will start
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      

        
    }

    // This method (action) here is readed by the new input system. Since there was a "Fire" action there, we name this method "OnFire" so it can read it.
    // If we wrote an action called "Kickflip" on the new input system, we would name this method "OnKickflip".
      void OnFire(InputValue value)        // there are stuff inside the ( ) because we NEED to define an InputValue or another class that exists on the new input system.
    {                                      // because this is how the N.I.S. will know what type of action the button will perform.
        fire = value.isPressed;
        
        GameObject newBullet = Instantiate(bullet, gunPosition.position, gunPosition.rotation);     // create a bullet where we want and facing where we want (this case, the gun).
        
        
        
        Debug.Log("I am firing !");           // i used this to check if the input (pressing the button) was working, cause the bullet wasn´t at the time.
    }
}
