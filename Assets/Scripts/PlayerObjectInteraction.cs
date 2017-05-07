using UnityEngine;
using System.Collections;

public class PlayerObjectInteraction : MonoBehaviour {


	private Camera fpsCam;                                                                      
	private Vector3 rayOrigin;
	private RaycastHit hit;
	public bool isItem;
	public GameObject interactText;
	public float distanceToSee;
	public Inventory inventory;
	public Pfand pfand;
	public Catapult catapult;



	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		fpsCam = GetComponent<Camera>();
		rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3(0.5f,0.5f,0.0f));
	}

	void Update () {
		Debug.DrawRay (this.transform.position,fpsCam.transform.forward * distanceToSee,Color.green);
		if (Physics.Raycast (this.transform.position, fpsCam.transform.forward, out hit, distanceToSee)) {
			itemInteraction ();
		} else {
			interactText.SetActive (false);
		}

	}

	void itemInteraction(){

		//Debug.Log ("I hit " + hit.collider.gameObject);
		if (hit.transform.CompareTag("Item")) {
			interactText.SetActive (true);
			isItem = true;
			if (Input.GetKeyDown ("e")) {
				Destroy (hit.transform.gameObject);
				hit.transform.gameObject.SendMessage ("ImmediateReaction");
				interactText.SetActive (false);
				isItem = false;
			}
		} else if(hit.transform.CompareTag("Door")){
			interactText.SetActive (true);
			if(Input.GetKeyDown("e")){
				hit.transform.gameObject.SendMessage ("Teleport");
				interactText.SetActive (false);
			}
		}
		else if(hit.transform.CompareTag("Pfandautomat")){
			interactText.SetActive (true);
			pfand = hit.transform.gameObject.GetComponent<Pfand> ();
			if (Input.GetKeyDown ("e")) {
				pfand.SendMessage ("PfandAbgeben");
			}
		}
		else if(hit.transform.CompareTag("mini_tanker")){
			interactText.SetActive (true);
			catapult = hit.transform.gameObject.GetComponent<Catapult> ();
			if(Input.GetKeyDown("e")){
				catapult.SendMessage ("CatapultPlayer");
			}
		}
		else {
			interactText.SetActive (false);
			isItem = false;
		}
	
	}

}
