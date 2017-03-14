using UnityEngine;
using System.Collections;

public class UIHandler : MonoBehaviour {

	bool isActive = false;
	public Inventory inventory;
	public ESCMenu menu;
	public GameObject reticle;

	// Update is called once per frame
	void Update () {
		if (!isActive) {
			if (Input.GetButtonDown ("Inventory")) {
				isActive = true;
				inventory.showInventory ();
			} else if (Input.GetButtonDown ("Menu")) {
				isActive = true;
				menu.showESCMenu ();
			}
		} else if (isActive) {
			if(Input.GetButtonDown("Inventory")){
				isActive = false;
				inventory.hideInventory ();
			}
			else if(Input.GetButtonDown("Menu")){
				isActive = false;
				menu.hideESCMenu ();
			}
		}

	}
}
