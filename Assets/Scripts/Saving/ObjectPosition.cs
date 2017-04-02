using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.Scripting;

[System.Serializable]
public class ObjectPosition  {

//	public GameObject[] sceneObjects;
//	public Vector3[] positions;

	//Positionen der GameObjects
	public float[] x;
	public float[] y;
	public float[] z;

	public ObjectPosition(){
		x = new float[10];
	}

}
