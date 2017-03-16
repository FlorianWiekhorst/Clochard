using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Inventory : MonoBehaviour {

	public GameObject inventory;
	public GameObject reticle;
	public InvDragHandler dragHandler;
	public Image[] itemImages = new Image[numItemSlots];
	public Item[] items = new Item[numItemSlots];
	public GameObject[] itemPrefabs = new GameObject[numItemSlots];
	public const int numItemSlots = 10;
	CursorLockMode wantedMode;

	void Awake(){
		inventory = GameObject.Find ("Inventory");
		reticle = GameObject.Find ("Reticle");
	}

	public void showInventory(){
		inventory.GetComponent<CanvasGroup> ().alpha = 1f;
		reticle.GetComponent<CanvasGroup> ().alpha = 0f;
//		reticle.SetActive(false);
//		inventory.SetActive(true);
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		Time.timeScale = 0f;
	
	}

	public void hideInventory(){
		inventory.GetComponent<CanvasGroup> ().alpha = 0f;
		reticle.GetComponent<CanvasGroup> ().alpha = 1f;
//		reticle.SetActive(true);
//		inventory.SetActive(false);
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
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i] == itemToRemove)
			{
				items[i] = null;
				itemImages[i].sprite = null;
				itemImages[i].enabled = false;
				return;
			}
		}
	}


}
