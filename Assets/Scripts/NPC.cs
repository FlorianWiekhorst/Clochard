//This is just supposed to be pseudo code

using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof (UnityEngine.AI.NavMeshAgent))]
public class NPC : MonoBehaviour{ 

    //public Transform npcPos;
	//public Transform goal;
	//Random rnd = new Random();
	UnityEngine.AI.NavMeshAgent agent;

	public Transform target;

	void start()
	{

		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	    //Move();
		agent.destination = target.position;
	}




}