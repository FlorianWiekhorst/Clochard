using UnityEngine;
using System.Collections;

public class PlayerObjectInteraction : MonoBehaviour {


	private Camera fpsCam;                                              // Holds a reference to the first person camera
	private LineRenderer laserLine;                                     // Reference to the LineRenderer component which will display our laserline
	private Vector3 rayOrigin;
	private RaycastHit hit;
	public bool isItem;
	public GameObject interactText;

	void Start () {
		fpsCam = GetComponent<Camera>();
		rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3(0.5f,0.5f,0.0f));
		//rayOrigin = rayOrigin + ( fpsCam.transform.forward * 0.5f ); 
	}

	void Update () {
		if (Physics.Raycast (rayOrigin, fpsCam.transform.forward, out hit, 30.0f))
		{
			Debug.DrawRay (fpsCam.transform.position,fpsCam.transform.forward,Color.green);
			if (hit.transform.CompareTag("Item")) {
				interactText.SetActive (true);
				isItem = true;
				if (Input.GetKeyDown ("e")) {
					Destroy (hit.transform.gameObject);
				}
				print ("Works" + fpsCam.transform.position);
			} else {
				interactText.SetActive (false);
				isItem = false;
			}
		}

	}
}
