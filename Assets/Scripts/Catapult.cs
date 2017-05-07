using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour {

	public GameObject player;

	void Start(){
		player = GameObject.Find ("_Player");
	}

	public void CatapultPlayer(){
		Debug.Log ("Boom Baby");
		player.gameObject.GetComponent<Rigidbody> ().AddRelativeForce (0, 50.0f, 0, ForceMode.Impulse);
	}

}
