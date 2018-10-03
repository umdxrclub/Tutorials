using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMoveCube : MonoBehaviour
{
    public Transform player;

    NavMeshAgent navAgent;

	void Start () {
        navAgent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
        NavMeshPath path = new NavMeshPath();
        navAgent.CalculatePath(player.position, path);
        navAgent.SetPath(path);
	}
}
