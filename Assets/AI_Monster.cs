using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Monster : MonoBehaviour
{
    private NavMeshAgent AI_Agent;
   [SerializeField] private GameObject Player;
    //public GameObject Panel_GaveOver;

    public Transform[] WayPoints;
    public int Current_Patch;

    public enum AI_State { Patrol, Stay, Chase };
    public AI_State AI_Enemy;
    public GameObject RyanGosling;

    void Start()
    {
        AI_Agent = gameObject.GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
       if (AI_Enemy == AI_State.Patrol)
        {
            AI_Agent.isStopped = false;
           // gameObject.GetComponent<Animator>().SetBool("isRunning", true);
           AI_Agent.SetDestination(WayPoints[Current_Patch].transform.position);
            float Patch_Dist = Vector3.Distance(WayPoints[Current_Patch].transform.position, gameObject.transform.position);
            if (Patch_Dist < 2)
            {
                Current_Patch++;
                Current_Patch = Current_Patch % WayPoints.Length;
            }
        } 
        if (AI_Enemy == AI_State.Stay)
        {
            gameObject.GetComponent<Animator>().SetBool("isRunning", false);
            AI_Agent.isStopped = true;
        }
        if (AI_Enemy == AI_State.Chase)
        {
            gameObject.GetComponent<Animator>().SetBool("isRunning", true);
            AI_Agent.SetDestination(Player.transform.position);
            (gameObject.GetComponent("maniak") as MonoBehaviour).enabled=false;
            Debug.Log("active");
            gameObject.GetComponent<Animator>().SetBool("isIdleGun", false);
        }


        float Dist_Player = Vector3.Distance(Player.transform.position, gameObject.transform.position);
        if (Dist_Player < 2)
        {
            RyanGosling.SetActive(false);
           // Panel_GaveOver.SetActive(true);
        }
    }
}