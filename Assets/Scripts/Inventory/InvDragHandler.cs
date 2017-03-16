using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class InvDragHandler : MonoBehaviour,IBeginDragHandler, IDragHandler,IEndDragHandler  {
	
//  public GameObject gameObj;
//	public Item item;
//	EventTrigger trigger;
//	public GameObject objBeingDragged;
//	public RectTransform rectTransform;
	Vector2 startPosition;
	RectTransform startTransform;
	GameObject inventoryObj;
	Inventory inventory;

	void Awake(){
		inventoryObj = GameObject.Find ("Inventory");
		inventory = inventoryObj.GetComponent<Inventory> ();
	}


	public void OnBeginDrag(PointerEventData eventData){
		startTransform = transform as RectTransform;
		startPosition = startTransform.position;
		Debug.Log ("Start Drag");
	}


	public void OnDrag (PointerEventData eventData)
	{
		Debug.Log (startPosition);
		this.transform.position = eventData.position;


		//throw new System.NotImplementedException ();
	}

	public void OnEndDrag(PointerEventData eventData){
		Debug.Log ("End Drag");
	}

}
