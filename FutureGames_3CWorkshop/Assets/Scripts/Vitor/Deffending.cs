using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deffending : MonoBehaviour
{
    [SerializeField] GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            player.GetComponent<PlayerHealth>().TakeShieldDamage(5f);
            Debug.LogError("im deffending!");
        }


    }
}
