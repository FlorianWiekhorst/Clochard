using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {
	public Button startButton, quitButton,settingsButton;
	public GameObject kran;

	void Start(){
		startButton.onClick.AddListener (StartTask);
		quitButton.onClick.AddListener (QuitTask);
		settingsButton.onClick.AddListener (SettingsTask);
		Time.timeScale = 1.0f;
	}

	void StartTask()
	{
		SceneManager.LoadScene ("Scene_01");
	}

	void SettingsTask(){
		Debug.Log ("Works.");
		kran.GetComponent<Rigidbody> ().AddForce(kran.transform.forward * 500f,ForceMode.Impulse);
	}

	void QuitTask(){
		Application.Quit();
	}
}
