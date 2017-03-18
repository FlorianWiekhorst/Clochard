using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour {

	public Vector2 offset;
	public bool isShown;
	public GameObject toolTipObj;
	private Vector3 toolTipPos; 


	private void Start(){
		ToggleToolTip (false);
	}

	public void ToggleToolTip(bool enabled){
		if (enabled) {
			toolTipObj.SetActive (true);
			toolTipObj.transform.position = Input.mousePosition;
		}
		else if(!enabled){
			toolTipObj.SetActive (false);
		}

	}

}
