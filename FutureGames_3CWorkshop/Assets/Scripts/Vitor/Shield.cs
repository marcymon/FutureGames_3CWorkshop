using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shield : MonoBehaviour
{
    public bool deffending;
    [SerializeField] GameObject shielding;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
             if (deffending)
            {
                IsDeffending(true);
            }
        }

        
    }

    public void IsDeffending(bool shield)
    {
        if (deffending)
        {
            shield = true;
            shielding.SetActive(true);
        }

        shield = false;
        shielding.SetActive(false);
        
    }

    

    void OnShield(InputValue value)
    {
       deffending = value.isPressed;


    }
}
