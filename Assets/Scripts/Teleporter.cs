using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour {

	public string scene;
	AudioSource source;
	public AudioClip clip;
	bool sound_played;

	void Awake(){
		source = GetComponent<AudioSource> ();
	}

	void Teleport(){
		source.PlayOneShot (clip);
		Invoke("TeleportDelay",2);
	}

	void TeleportDelay(){
		SceneManager.LoadScene (scene);
	}

}
