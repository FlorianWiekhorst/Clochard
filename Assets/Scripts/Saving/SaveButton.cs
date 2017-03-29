using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SaveButton : MonoBehaviour {

	private Button saveButton;

	void Start () {
		saveButton = GetComponent<Button>();
		saveButton.onClick.AddListener (SaveGame);
	}

	void SaveGame(){
		SaveManager.Save ();
	}

}
