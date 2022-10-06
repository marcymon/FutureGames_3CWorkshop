using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dash : MonoBehaviour
{
    private CharacterController controller;
    private Transform playerBody;
    private PlayerMovementController playerMovement;
    public float maxDashTime = 1f;
    public float dashDistance = 30f;
    private float dashSpeedOnStop = 0.1f;
    private float currentDashTime;
    private float dashSpeed = 6f;
    [SerializeField] GameObject gun;
    private Vector3 moveDirection;
    private bool dash;



    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
               
       
    }

    // Update is called once per frame
    void Update()
    {
              
              if (dash)
            {
                currentDashTime = 0;
            }
            if (currentDashTime < maxDashTime)
            {
                moveDirection = gun.transform.right * dashDistance;
                currentDashTime += dashSpeedOnStop;
            }
            else
            {
                moveDirection = Vector3.zero;
            }
           
        
    }     

      

       void OnDash(InputValue value)
       {
        dash = value.isPressed;
        controller.Move(moveDirection * Time.deltaTime * dashSpeed);
       }


}
    

