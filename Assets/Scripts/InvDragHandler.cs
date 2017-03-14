using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InvDragHandler : MonoBehaviour,IPointerDownHandler  {
	
    public GameObject gameObj;
	public Item item;
	EventTrigger trigger;
//	public GameObject objBeingDragged;
//	public RectTransform rectTransform;
//	Vector3 startPosition;

	void Awake(){

	}

	public void OnPointerDown (PointerEventData eventData){
		Debug.Log ("Mouse Down");
		//throw new System.NotImplementedException ();
	}

	void DoSomething(){
		Debug.Log ("Clicked");
	}

}
