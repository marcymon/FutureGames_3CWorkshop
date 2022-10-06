using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fire : MonoBehaviour
{
    private CharacterController controller;
    private bool fire;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject gunPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fire)
        {
            Vector3 force = transform.forward * 500f;
        }
    }

      void OnFire(InputValue value)
    {
        fire = value.isPressed;
        GameObject newBullet = Instantiate(bullet);
        newBullet.transform.position = gunPosition.transform.position;
        newBullet.GetComponent<Projectile>();
        
        Debug.Log("I am firing !");
    }
}
