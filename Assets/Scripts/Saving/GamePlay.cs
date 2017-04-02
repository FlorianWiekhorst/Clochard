using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour {

	public GameObject[] gameObjects;
	public ObjectPosition pos;

	void Start(){
		gameObjects = GameObject.FindObjectsOfType (typeof(GameObject)) as GameObject[];
		for(int i = 0;i < gameObjects.Length;i++){
			pos.x[i] = gameObjects [i].transform.position.x;
			pos.y[i] = gameObjects [i].transform.position.y;
			pos.z[i] = gameObjects [i].transform.position.z;
		}

	}

}
