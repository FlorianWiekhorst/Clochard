using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TooltipButton : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler {

	private Text text;
	private Color cacheColor;

	// Use this for initialization
	private void Start () {
		text = GetComponent<Text> ();
	}

	#region IPointerEnterHandler implementation
	public void OnPointerEnter (PointerEventData eventData)
	{
		cacheColor = text.color;
		text.color = Color.red;
	}
	#endregion

	#region IPointerExitHandler implementation

	public void OnPointerExit (PointerEventData eventData)
	{
		text.color = cacheColor;
	}

	#endregion
}
