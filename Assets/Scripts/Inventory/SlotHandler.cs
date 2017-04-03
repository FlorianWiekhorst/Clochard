using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotHandler : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler {

	public bool pointerIsOver;
	public Outline outline; 
	Tooltip tooltip;
	GameObject toolTipObj;
	public GameObject toolTipBG;
	public bool isOverToolTip;
	public GameObject slotActive;
	Color grayish;


	void Start(){
		slotActive = null;
		isOverToolTip = false;
		toolTipObj = GameObject.Find ("Tooltip");
		tooltip = toolTipObj.GetComponent<Tooltip> ();
		outline = this.gameObject.GetComponent<Outline> (); 
		grayish = new Color (0.34f, 0.34f, 0.34f);

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
				slotActive = null;
			}
		
		}
	}


	#region IPointerEnterHandler implementation
	public void OnPointerEnter (PointerEventData eventData)
	{
		pointerIsOver = true;
		outline.effectColor = Color.white;
	
	}
	#endregion

	#region IPointerExitHandler implementation

	public void OnPointerExit (PointerEventData eventData)
	{
		pointerIsOver = false;
		ResetOutlineColor ();

	}

	#endregion

	public void ResetOutlineColor(){
		
		outline.effectColor = Color.black;
	}

}
