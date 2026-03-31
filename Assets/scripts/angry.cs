using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class angry : MonoBehaviour
{
    public Animator animator;
    public Transform target;
    public float chaseSpeed = 3f;
    public float obstacleAvoidanceDistance = 2f;

    private NavMeshAgent navMeshAgent;
    private bool isChasing = false;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = chaseSpeed;
    }

    private void Update()
    {
        if (isChasing && target != null)
        {
            navMeshAgent.SetDestination(target.position);

            if (navMeshAgent.remainingDistance > obstacleAvoidanceDistance)
            {
                animator.SetBool("isRunning", true);
            }
            else
            {
                animator.SetBool("isRunning", false);
            }
        }
    }

    public void StartChase()
    {
        if (!isChasing)
        {
            animator.SetTrigger("isAngry");
            isChasing = true;
        }
    }
}
