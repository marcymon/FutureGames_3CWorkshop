using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dash : MonoBehaviour
{
    // Script for dashing. The variables will be explained on the update.

    private CharacterController controller;
    private Transform playerBody;
    private PlayerMovementController playerMovement;
    public float maxDashTime = 1f;
    public float dashDistance = 300f;
    private float dashSpeedOnStop = 0.1f;
    private float currentDashTime;
    private float dashSpeed = 6f;
    [SerializeField] GameObject gun;
    private Vector3 moveDirection;
    private bool dash;



    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();               // im not sure if this is necessary anymore, but it will stay there.
        
       
    }

    // Update is called once per frame
    void Update()
    {
              
              if (dash)                                 // if button is pressed
            {
                currentDashTime = 0;                    // the time for the dash starts
            }
            if (currentDashTime < maxDashTime)          // while the dash time is lesser than what we set as the max time
            {
                moveDirection = gun.transform.right * dashDistance;         //  move on the direction that the gun is facing * the distance we set
                currentDashTime += dashSpeedOnStop;                         //  slow down on the stop
            }
            else                                              // if the dash time is greater than what we set as max time
            {
                moveDirection = Vector3.zero;                
            }
           
        
    }     

      

       void OnDash(InputValue value)                                    // same explanation as Fire script.
       {
        dash = value.isPressed;
        controller.Move(moveDirection * Time.deltaTime * dashSpeed);    // player moves on the direction we set, on the speed we set, in real time.
       }

  


}
    

