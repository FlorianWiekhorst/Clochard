using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pfand : MonoBehaviour {

	PlayerManager player_manager;
	GameObject[] slots;
	Inventory inventory;

	void Start () {
		slots = GameObject.FindGameObjectsWithTag ("Slot");	
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory>();
		player_manager = GameObject.Find ("_Player").GetComponent<PlayerManager>();
	}

	void PfandAbgeben(){
		for(int i = 0;i < slots.Length;i++){
			if (slots [i].GetComponentInChildren<InvDragHandler> ().item != null && slots [i].GetComponentInChildren<InvDragHandler> ().item.name == "Beer") {
				inventory.RemoveItem (slots[i].GetComponentInChildren<InvDragHandler>().item,i);
				player_manager.AddMoney (2);
			} else {
				continue;
			}
		}
	}

}
