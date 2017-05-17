using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadButton : MonoBehaviour {

	private Button loadButton;
//	public ObjectPosition pos;

	void Start () {
		loadButton = GetComponent<Button>();
		loadButton.onClick.AddListener (LoadGame);

	}

	void LoadGame(){
		SceneManager.LoadScene ("MainMenu");
	}
}
