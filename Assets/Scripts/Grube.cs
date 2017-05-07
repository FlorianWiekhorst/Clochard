using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grube : MonoBehaviour {

	/*	This Script is for the GameObject 'Grube'.
	 * 
	 *  It destroys the Object which is thrown into the pit,
	 *  and spawns Object high in the air.
	 * 
	 *  An object into the pit ->    + destroys the object
	 * 								 + plays one of three sounds
	 * 								 + spawns X objects to rain down
	*/

	public AudioClip[] sounds;		  		    //Array for my Soundfiles
	public GameObject[] spawnObj_prefabs;		//Array for the spawnObjects

	void playAudio(int clipNumber){
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = sounds [clipNumber];
		if (!audio.isPlaying) {
			audio.Play ();
		}
	}
		

	void OnTriggerEnter(Collider other)
	{
		//Apfel in die Grube:
		if (other.gameObject.CompareTag ("Apple")) {
			Destroy(other.gameObject);
			playAudio (0);

			for (int j = 0; j < 12; j++) {
				//Erschafft zufälligen SpawnPunkt am Himmel über der Insel
				Vector3 randomSpawn = new Vector3 (Random.Range (-350, -80),Random.Range (220, 510), Random.Range (-150, 50));
				Instantiate (spawnObj_prefabs [2], randomSpawn, Quaternion.identity);
			}
		}


		//Waschpulver in die Grube:
		if (other.gameObject.CompareTag ("Washy")) {
			Destroy(other.gameObject);
			playAudio(2);
		}


		//Frau in die Grube:
		if (other.gameObject.CompareTag ("Woman")) {
			Destroy(other.gameObject);
			playAudio(1);
		}


		//Cornflakes in die Grube:
		if (other.gameObject.CompareTag ("Cornflakes")) {
			Destroy(other.gameObject);
			playAudio(0);
		}


		//Flasche in die Grube:
		if (other.gameObject.CompareTag ("Bottle")) {
			Destroy(other.gameObject);
			playAudio(1);
		}


		//Dose in die Grube:
		if (other.gameObject.CompareTag ("ColaCan")) {
			Destroy(other.gameObject);
			playAudio(2);


		}

		//Wassermelone in die Grube:
		if (other.gameObject.CompareTag ("Watermelon")) {
			Destroy(other.gameObject);
			playAudio(1);
		}
	}
}