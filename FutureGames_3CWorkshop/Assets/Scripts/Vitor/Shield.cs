using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shield : MonoBehaviour
{
    public bool deffending;
    public float timer;
   [SerializeField] GameObject shielding;
    

    private void Update()
    {
        if(deffending)
        {
            timer += Time.deltaTime;
            if (timer >= 5f)
            {
                shielding.SetActive(false);
                timer = 0;
            }
        }
    }


    public void IsDeffending(bool shield)
    {
       
            shield = true;
            
        
    }

    

    void OnShield(InputValue value)
    {
       deffending = value.isPressed;
        shielding.SetActive(true);

        


    }
}
