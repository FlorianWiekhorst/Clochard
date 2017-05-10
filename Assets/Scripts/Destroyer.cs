using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	/*	Destroys any Object with tag = "Item" on collision.
		Destroyer is placed a few meters under the ocean, 
		to remove Items that dropped of the island. 
	*/

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Item")) {
			Destroy(other.gameObject);
		}
			
		if (other.gameObject.CompareTag ("Apple")) {
			Destroy(other.gameObject);
		}
			
		if (other.gameObject.CompareTag ("Washy")) {
			Destroy(other.gameObject);
		}
			
		if (other.gameObject.CompareTag ("Woman")) {
			Destroy(other.gameObject);
		}

		if (other.gameObject.CompareTag ("Cornflakes")) {
			Destroy(other.gameObject);
		}

		if (other.gameObject.CompareTag ("Bottle")) {
			Destroy(other.gameObject);
		}
			
		if (other.gameObject.CompareTag ("ColaCan")) {
			Destroy(other.gameObject);
		}
			
		if (other.gameObject.CompareTag ("Watermelon")) {
			Destroy(other.gameObject);
		}


	}
}
