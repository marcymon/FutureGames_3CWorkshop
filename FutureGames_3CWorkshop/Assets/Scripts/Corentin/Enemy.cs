using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject followPlayer;
    [SerializeField] float speedPosition = 0.5f;

    public Transform facing;
    public Vector3 playerPosition;
    public float enemyDamage = 20;
    
    void Update()
    {
        MoveTowardsTarget();
        transform.LookAt(new Vector3(facing.position.x, transform.position.y, facing.position.z));
    }

    void MoveTowardsTarget()
    {
        transform.position = Vector3.Lerp(transform.position, followPlayer.transform.position,
            speedPosition * Time.deltaTime);
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(enemyDamage);
        }

    }

}
