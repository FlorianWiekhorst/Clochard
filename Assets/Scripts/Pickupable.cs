using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour {

	public Item item;               // The item asset to be added to the Inventory.


	private Inventory inventory;    // Reference to the Inventory component.


	void Start()
	{
		inventory = FindObjectOfType<Inventory>();
	}


	void ImmediateReaction()
	{
		inventory.AddItem(item);
		Debug.Log ("Poop");
	}
}
