using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotHandler : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler {

	public bool pointerIsOver;
	Outline outline; 
	Color cacheColor;

	void Awake(){
		outline = this.gameObject.GetComponent<Outline> ();
	}

	#region IPointerEnterHandler implementation
	public void OnPointerEnter (PointerEventData eventData)
	{
		cacheColor = outline.effectColor;
		outline.effectColor = Color.white;
		//throw new System.NotImplementedException ();
	}
	#endregion

	#region IPointerExitHandler implementation

	public void OnPointerExit (PointerEventData eventData)
	{
		outline.effectColor = cacheColor;
		throw new System.NotImplementedException ();
	}

	#endregion

	#region IPointerClickHandler implementation

	public void OnPointerClick (PointerEventData eventData)
	{
		throw new System.NotImplementedException ();
	}

	#endregion
}
