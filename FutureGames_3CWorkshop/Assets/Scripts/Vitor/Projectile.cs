using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private PlayerHealth playerHealth;
  public float force = 0.005f;

  private void Start()
  {
    gameObject.GetComponent<Rigidbody>().AddForce(transform.right * force, ForceMode.Force);
  }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject, 5f);
    }

}
