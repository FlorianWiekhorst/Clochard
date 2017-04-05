using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class InvDragHandler : MonoBehaviour,IBeginDragHandler, IDragHandler,IEndDragHandler  {
	
 
	public Item item;

	public GameObject gameObj;

	Vector2 startPosition;
	RectTransform startTransform;
	GameObject inventoryObj;
	Inventory inventory;
	RectTransform invRect;

	Transform cachedParent;

	SlotHandler slotHandler;
	public int slotnumber;
	GameObject slots;

	void Awake(){
		inventoryObj = GameObject.Find ("Inventory");
		inventory = inventoryObj.GetComponent<Inventory> ();
		slots = GameObject.Find ("Slots");
		slotHandler = transform.parent.GetComponent<SlotHandler> ();
		invRect = inventoryObj.GetComponent<RectTransform> ();

	}


	public void OnBeginDrag(PointerEventData eventData){
		//For later reset purposes
		cachedParent = this.transform.parent;
		this.gameObject.GetComponent<CanvasGroup> ().blocksRaycasts = false;

		//Setting the new Parent
		this.transform.SetParent (inventoryObj.transform);
		startTransform = transform as RectTransform;
		this.transform.SetAsLastSibling ();
		startPosition = startTransform.position;
		Debug.Log ("Start Drag");

	}


	public void OnDrag (PointerEventData eventData)
	{
		Debug.Log (startPosition);
		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData){
		Debug.Log ("End Drag");
		if (!inventory.pointerOver) {
			inventory.RemoveItem (item,slotHandler.slotnumber);
			slotHandler.slotActive = null;
			slotHandler.ResetOutlineColor ();
			this.transform.SetParent (cachedParent.transform);
			this.transform.position = startPosition;
		} else {
			this.transform.SetParent (cachedParent.transform);
			this.transform.position = startPosition;
			slotHandler.slotActive = null;
		}
		this.gameObject.GetComponent<CanvasGroup> ().blocksRaycasts = true;

	}


}
