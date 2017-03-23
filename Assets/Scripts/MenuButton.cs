using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {
	public Button startButton, quitButton;

	void Start(){
		startButton.onClick.AddListener (StartTask);
		quitButton.onClick.AddListener (QuitTask);
	}

	void StartTask()
	{
		SceneManager.LoadScene ("_Flo_Game_01");
	}
	void QuitTask(){
		Application.Quit();
	}
}
