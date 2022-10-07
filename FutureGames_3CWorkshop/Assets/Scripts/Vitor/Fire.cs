using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fire : MonoBehaviour
{
    private CharacterController controller;
    private bool fire;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform gunPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
      

        
    }

      void OnFire(InputValue value)
    {
        fire = value.isPressed;
        
        GameObject newBullet = Instantiate(bullet, gunPosition.position, gunPosition.rotation);
        
        
        
        Debug.Log("I am firing !");
    }
}
