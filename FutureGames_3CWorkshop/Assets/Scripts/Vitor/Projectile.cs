using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody bullet;
    public float speed = 50f;
    private bool isActive;
  
    public void Initialize()
    {
        
         isActive = true; 
        
        
    }

    private void Update()
    {
        if(isActive)
        {
            bullet.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
        }
    }
}
