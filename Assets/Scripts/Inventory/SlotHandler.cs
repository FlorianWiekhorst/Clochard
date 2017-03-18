using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotHandler : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler {

	public bool pointerIsOver;
	Outline outline; 
	Color cacheColor;
	Tooltip tooltip;
	GameObject toolTipObj;
	public GameObject toolTipBG;
	public bool isOverToolTip;
	public GameObject slotActive;


	void Start(){
		slotActive = null;
		isOverToolTip = false;
		toolTipObj = GameObject.Find ("Tooltip");
		tooltip = toolTipObj.GetComponent<Tooltip> ();
		outline = this.gameObject.GetComponent<Outline> ();
	}

	void Update(){
		if(Input.GetMouseButtonDown(1) && pointerIsOver){
			//Debug.Log ("Mouse clicked");
			tooltip.SendMessage ("ToggleToolTip",true);
			slotActive = this.gameObject;
		}
		else if(Input.GetMouseButtonDown(0) && !isOverToolTip){
			if (toolTipBG.activeSelf) {
				//Debug.Log ("Disabled");
				tooltip.SendMessage ("ToggleToolTip",false);
			}
		
		}
	}


	#region IPointerEnterHandler implementation
	public void OnPointerEnter (PointerEventData eventData)
	{
		pointerIsOver = true;
		cacheColor = outline.effectColor;
		outline.effectColor = Color.white;
	
	}
	#endregion

	#region IPointerExitHandler implementation

	public void OnPointerExit (PointerEventData eventData)
	{
		pointerIsOver = false;
		outline.effectColor = cacheColor;

	}

	#endregion


}
