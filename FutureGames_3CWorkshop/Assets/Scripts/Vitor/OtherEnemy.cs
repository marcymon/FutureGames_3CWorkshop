using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OtherEnemy : MonoBehaviour
{
    // making the enemy follow player using navmesh

    public float enemyDamage = 15f;
    private NavMeshAgent agent;
    private float closeEnough = 2f;
    private float timeBetweenAttacks = 0;
    private GameObject player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");

    }
    void Update()
    {
        agent.SetDestination(player.transform.position);

        agent.isStopped = false;
        if (agent.remainingDistance <= closeEnough)
        {
            agent.isStopped = true;
            Attack();
        }

    }
  /*  private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Player"))
       {
           collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(enemyDamage);
       }
         
        
    }    */

    private void Attack()
    {
                    timeBetweenAttacks += Time.deltaTime;
        if (timeBetweenAttacks >= 2f)
        {
            player.GetComponent<PlayerHealth>().TakeDamage(enemyDamage);
            timeBetweenAttacks = 0f;
        }
    }

}
