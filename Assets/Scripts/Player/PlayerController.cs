using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float walkSpeed;
	public float jumpSpeed;
	public float runSpeed;
	public float fallingDamageThreshold;


	private CharacterController controller;
	private Transform playerTransform;

	void Start () {
		controller = GetComponent<CharacterController> ();	
		playerTransform = transform;
	}
	

	void FixedUpdate () {
		
	}
}
