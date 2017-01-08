//This is just supposed to be pseudo code

using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof (NavMeshAgent))]
public class NPC : MonoBehaviour{ 

    //public Transform npcPos;
	//public Transform goal;
	//Random rnd = new Random();
	NavMeshAgent agent;

	public Transform target;

	void start()
	{

		agent = GetComponent<NavMeshAgent>();
	    //Move();
		agent.destination = target.position;
	}




}