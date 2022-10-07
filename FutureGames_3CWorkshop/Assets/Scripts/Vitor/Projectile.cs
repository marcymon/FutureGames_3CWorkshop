using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

  public float force = 1500f;

  private void Start()
  {
    gameObject.GetComponent<Rigidbody>().AddForce(transform.right * force, ForceMode.Impulse);
  }
}
