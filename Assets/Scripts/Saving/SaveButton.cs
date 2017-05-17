using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SaveButton : MonoBehaviour {

	private Button saveButton;
	public GameObject player;
	public GameObject prefab;

	void Start () {
		player = GameObject.Find ("_Player");
		saveButton = GetComponent<Button>();
		saveButton.onClick.AddListener (SaveGame);
	}

	void SaveGame(){
		Instantiate (prefab,player.transform.position+(player.transform.forward*2),Quaternion.identity);
	}

}
