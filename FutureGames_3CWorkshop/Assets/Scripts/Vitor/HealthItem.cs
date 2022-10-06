using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
   public void OnCollisionEnter(Collision collision)
   {
      if(collision.gameObject.CompareTag("Player"))
      {
         Destroy(gameObject);
         Debug.LogError("yeah! You picked " + name);
      }
      
   }
}
