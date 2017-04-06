using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Arms : MonoBehaviour {
	
	Animator anim; 								// Reference to the players Arms animator component.

	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update () {
		if (Input.GetButtonDown ("F")) {		// Push 'F' to flip someone off
			anim.SetTrigger ("Middlefinger");
		}

		if (Input.GetMouseButtonDown(1)) {			// Hold LeftMouse to Block
			anim.SetBool("Block", true);
			if (Input.GetMouseButtonUp (1)) {			// Hold LeftMouse to Block
				anim.SetBool ("Block", false);
			}
		}

		if (Input.GetMouseButton(0)) {			// Push RightMouse to Punch
			anim.SetTrigger ("Punch");
		}

		if (Input.GetButtonUp ("E")) {			// Press E to pick something up
			anim.SetTrigger ("PickUp");
		}

		
		// Hier fehlt dann noch  "... to start eat animation "

	}
}
