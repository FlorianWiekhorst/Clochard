using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class InvDragHandler : MonoBehaviour, IDragHandler  {
	
    public GameObject gameObj;
	public Item item;
//	EventTrigger trigger;
//	public GameObject objBeingDragged;
//	public RectTransform rectTransform;
	Vector2 startPosition;
	RectTransform startTransform;

	void Awake(){
		startTransform = transform as RectTransform;
		startPosition = startTransform.position;
	}



	public void OnDrag (PointerEventData eventData)
	{
		Debug.Log ("Works.");
		startTransform = eventData.pointerEnter.transform as RectTransform;

		throw new System.NotImplementedException ();
	}



}
