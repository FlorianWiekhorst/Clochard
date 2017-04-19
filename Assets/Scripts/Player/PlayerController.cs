using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float walkSpeed = 6.0f;
	public float jumpSpeed = 10.0f;
	public float runSpeed = 11.0f;
	public float gravity = 20.0f;
	public float fallingDamageThreshold;


	private CharacterController controller;
	private Transform playerTransform;
	private Vector3 moveDirection = Vector3.zero;
	private float speed;
	private bool jumping;


	void Start () {
		controller = GetComponent<CharacterController> ();	
		playerTransform = transform;
		speed = walkSpeed;
		jumping = false;
	}
	

	void Update () {
		if(controller.isGrounded){
			moveDirection = new Vector3 (Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= (Input.GetButton("Run") ? runSpeed : walkSpeed);
			if(Input.GetButton("Jump")){
				moveDirection.y = jumpSpeed;
				jumping = true;
			}
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
	}


}
