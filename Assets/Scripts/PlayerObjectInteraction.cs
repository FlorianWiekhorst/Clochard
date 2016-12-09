using UnityEngine;
using System.Collections;

public class PlayerObjectInteraction : MonoBehaviour {


	private Camera fpsCam;                                              // Holds a reference to the first person camera
	private LineRenderer laserLine;                                     // Reference to the LineRenderer component which will display our laserline
	private Vector3 rayOrigin;
	private RaycastHit hit;
	public bool isItem;

	void Start () {
		fpsCam = GetComponent<Camera>();
		rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3(0.5f,0.5f,0.0f));
	}

	void Update () {
		if (Physics.Raycast (rayOrigin, fpsCam.transform.forward, out hit, 40.0f))
		{
			if (hit.transform.tag == "Item") {
				isItem = true;
				if (Input.GetKeyDown ("e")) {
					Destroy (hit.transform.gameObject);
				}
				print ("Works" + fpsCam.transform.position);
			} else {
				isItem = false;
			}
		}

	}
}
