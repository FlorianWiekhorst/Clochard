using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler {

	public GameObject inventory;
	public GameObject reticle;
	public InvDragHandler dragHandler;
	public Image[] itemImages = new Image[numItemSlots];
	public Item[] items = new Item[numItemSlots];
	public GameObject[] itemPrefabs = new GameObject[numItemSlots];
	public const int numItemSlots = 15;
	CursorLockMode wantedMode;
	public bool pointerOver;
	public GameObject player;


	GameObject invBG;


	void Awake(){
		pointerOver = true;
		player = GameObject.Find ("_Player");
		inventory = GameObject.Find ("Inventory");
		reticle = GameObject.Find ("Reticle");
		invBG = GameObject.Find ("Inventory_background");
	}

	public void showInventory(){
		inventory.GetComponent<CanvasGroup> ().alpha = 1f;
		reticle.GetComponent<CanvasGroup> ().alpha = 0f;
		invBG.GetComponent<CanvasGroup>().alpha = 1f;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		Time.timeScale = 0f;
	
	}

	public void hideInventory(){
		inventory.GetComponent<CanvasGroup> ().alpha = 0f;
		reticle.GetComponent<CanvasGroup> ().alpha = 1f;
		invBG.GetComponent<CanvasGroup>().alpha = 0f;
		Cursor.visible = false;
		Cursor.lockState = wantedMode = CursorLockMode.Locked;
		Time.timeScale = 1f;
	}

	public void AddItem(Item itemToAdd){
		
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i] == null)
			{
				dragHandler = itemImages [i].GetComponent<InvDragHandler> ();


				items[i] = itemToAdd;
				itemPrefabs [i] = itemToAdd.prefab;

				dragHandler.gameObj = itemToAdd.prefab;
				dragHandler.item = itemToAdd;

				itemImages[i].sprite = itemToAdd.sprite;
				itemImages[i].enabled = true;
				return;
			}
		}
	}
	public void RemoveItem (Item itemToRemove)
	{
		
		Instantiate (itemToRemove.prefab,player.transform.position+(player.transform.forward*2),Quaternion.identity);
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i] == itemToRemove)
			{
				items[i] = null;
				itemPrefabs [i] = null;

				dragHandler.gameObj = null;
				dragHandler.item = null;

				itemImages[i].sprite = null;
				itemImages[i].enabled = false;
				return;
			}
		}
	}

	#region IPointerEnterHandler implementation
	public void OnPointerEnter (PointerEventData eventData)
	{
		pointerOver = true;
	}
	#endregion

	#region IPointerExitHandler implementation

	public void OnPointerExit (PointerEventData eventData)
	{
		pointerOver = false;
	}

	#endregion
}
