using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{

    private InputAction fire;
    private CharacterController controller;
    public PlayerInputActions playerControls;
    
    void Awake()
    {
        playerControls = new PlayerInputActions();
    }
    
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }
    
    void Update()
    {
        fire = playerControls.Player.Fire;
        fire.Enable();
        fire.performed += Fire;
    }

    private void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("I am firing !");
    }

}
