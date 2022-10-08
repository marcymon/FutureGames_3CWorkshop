using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // script to say how the projectile will behave

   
  public float force = 0.005f;

  private void Start()
  {
    gameObject.GetComponent<Rigidbody>().AddForce(transform.right * force, ForceMode.Force);          // gets the rigidbody component and add foce to the position we want it to
  }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))       //if the projectile collides with the enemy (who has the tag enemy)
        {
            Destroy(collision.gameObject);                // destroys the enemy
        }

        Destroy(gameObject, 5f);                          // bullet / projectile will destroy itself after 5 sec
    }

}
