using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deffending : MonoBehaviour
{
    // script to handle the damage while shielding

    [SerializeField] GameObject player;          // we need this to tell the player to receive the damage, since this script is on the shield.

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))                 // if the shield collides with the enemy (that has the enemy script)
        {
            player.GetComponent<PlayerHealth>().TakeShieldDamage(5f);                // the player will receive 5 of damage
            Debug.LogError("im deffending!");                                       // debug to check the errors
        }


    }
}
