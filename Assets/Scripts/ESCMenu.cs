using UnityEngine;
using System.Collections;

public class ESCMenu : MonoBehaviour {

	public GameObject menu;
	public GameObject reticle;

	public void showESCMenu(){
		menu.GetComponent<CanvasGroup> ().alpha = 1f;
		reticle.GetComponent<CanvasGroup> ().alpha = 0f;
		menu.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		Time.timeScale = 0f;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	public void hideESCMenu(){
		menu.GetComponent<CanvasGroup> ().alpha = 0f;
		reticle.GetComponent<CanvasGroup> ().alpha = 1f;
		menu.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		Time.timeScale = 1f;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
}
