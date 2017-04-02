using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadButton : MonoBehaviour {

	private Button loadButton;
//	public ObjectPosition pos;

	void Start () {
		loadButton = GetComponent<Button>();
		loadButton.onClick.AddListener (LoadGame);

	}

	void LoadGame(){
		SaveManager.Load ();
//		pos = SaveFile.current.pos;
//		for(int i = 0;i < pos.sceneObjects.Length;i++){
//			pos.sceneObjects [i].transform.position = pos.positions[i];
//		}
	}
}
