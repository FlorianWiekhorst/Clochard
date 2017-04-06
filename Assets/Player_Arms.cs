using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Arms : MonoBehaviour {
	
	Animator anim; 								// Reference to the players Arms animator component.

	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update () {
		if (Input.GetButtonDown ("F")) {			// Push 'F' to flip someone off
			anim.SetTrigger ("Middlefinger");
		}
	}
}
