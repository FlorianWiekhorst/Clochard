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
	}
}
