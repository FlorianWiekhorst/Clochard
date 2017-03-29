using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.Scripting;

[System.Serializable]
public class ObjectPosition :MonoBehaviour {

	public GameObject[] sceneObjects;
	public Vector3[] positions;

	public ObjectPosition(){
		sceneObjects = FindObjectsOfType(typeof(GameObject)) as GameObject[];
		for(int i = 0;i < sceneObjects.Length;i++){
			positions [i] = sceneObjects [i].transform.position;
		}
	}

}
