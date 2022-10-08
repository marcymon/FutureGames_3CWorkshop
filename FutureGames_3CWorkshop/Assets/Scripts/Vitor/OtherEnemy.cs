using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OtherEnemy : MonoBehaviour
{
    // making the enemy follow player using navmesh

    [SerializeField] GameObject player;
    public float enemyDamage = 15f;
    private NavMeshAgent nav;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        nav.SetDestination(player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Player"))
       {
           collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(enemyDamage);
       }

        
    }
}
