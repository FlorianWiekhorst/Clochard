using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotHandler : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler {

	public bool pointerIsOver;

	public void OnPointerEnter (PointerEventData eventData)
	{
		pointerIsOver = true;
		//throw new System.NotImplementedException ();
	}


	public void OnPointerExit (PointerEventData eventData)
	{
		pointerIsOver = false;
		//throw new System.NotImplementedException ();
	}

}
