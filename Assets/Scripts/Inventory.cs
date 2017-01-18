using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public int space = 10;
	public int[] items = new int[10];
	public GameObject inventory;
	public GameObject reticle;

	public void showInventory(){
		inventory.GetComponent<CanvasGroup> ().alpha = 0f;
		reticle.GetComponent<CanvasGroup> ().alpha = 1f;
		Time.timeScale = 1f;
	
	}

	public void hideInventory(){
		inventory.GetComponent<CanvasGroup> ().alpha = 1f;
		reticle.GetComponent<CanvasGroup> ().alpha = 0f;
		Time.timeScale = 0f;
	
	}


}
