using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public int space = 10;
	public int[] items = new int[10];
	public GameObject inventory;
	private bool isShowing = false;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("i")) {
			showInventory ();
		} 
	}


	void showInventory(){
		if (isShowing) {
			inventory.GetComponent<CanvasGroup> ().alpha = 0f;
			isShowing = false;
		} else {
			inventory.GetComponent<CanvasGroup> ().alpha = 1f;
			isShowing = true;
		}
	
	}


}
