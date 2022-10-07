using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    

   private void OnCollisionEnter(Collision collision)
   {
      if(collision.gameObject.CompareTag("Player"))
      {

         collision.gameObject.GetComponent<PlayerHealth>().Heal(15);
         Destroy(gameObject);

         Debug.LogError("yeah! You picked " + name);
      }
      
   }
}
