﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TooltipButton : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerDownHandler {

	private Text text;
	private Color cacheColor;
	GameObject[] slothandlerObj;
	public SlotHandler slothandler;
//	public InvDragHandler draghandler;
	GameObject inventoryObj;
	Inventory inventory;
	public GameObject selectedSlot;

	// Use this for initialization
	private void Start () {
		inventoryObj = GameObject.Find ("Inventory");
		inventory = inventoryObj.GetComponent<Inventory> ();
		//This is the PROBLEM
		//slothandlerObj = GameObject.FindGameObjectsWithTag ("Slot");
		slothandler = slothandlerObj[1].GetComponent<SlotHandler> ();
		text = GetComponent<Text> ();
		selectedSlot = slothandler.slotActive;
	}

	#region IPointerEnterHandler implementation
	public void OnPointerEnter (PointerEventData eventData)
	{
		cacheColor = text.color;
		text.color = Color.red;
		slothandler.isOverToolTip = true;
	}
	#endregion

	#region IPointerExitHandler implementation

	public void OnPointerExit (PointerEventData eventData)
	{
		slothandler.isOverToolTip = false;
		text.color = cacheColor;
	}

	#endregion

	#region IPointerDownHandler implementation

	public void OnPointerDown (PointerEventData eventData)
	{
		text.color = cacheColor;
		Debug.Log ("Clicked");
		if(text.text == "Use"){
			Debug.Log ("Used");
			slothandler.slotActive = null;
		}
		else if(text.text == "Drop"){
			selectedSlot = slothandler.slotActive;
			inventory.RemoveItem (selectedSlot.gameObject.GetComponentInChildren<InvDragHandler>().item);
		}
	}

	#endregion

}
