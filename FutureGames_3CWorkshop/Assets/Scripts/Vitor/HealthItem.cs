using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
                                // Script that is attached to the item. It serves so the item object knows what to do in the case it hits the player.

   private void OnCollisionEnter(Collision collision)     // the lines inside the ( ) means that we are calling the other object that we colide to "collision", so when we
   {                                                      // say "collision.gameObject" we mean the other object, not the one that is attached to this script.

      if(collision.gameObject.CompareTag("Player"))                 // if the object the item collides has the "Player" tag on it (we create this on the inspector).
      {

         collision.gameObject.GetComponent<PlayerHealth>().Heal(15);              // we find the PlayerHealth script on the object we collide, access the Heal method and add 15 to HP.
         Destroy(gameObject);                // the item destroy itself

         Debug.LogError("yeah! You picked " + name);       // Debug to check if it was working or not while i had trouble implementing it.
      }
      
   }
}
