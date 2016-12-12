using UnityEngine;
using System.Collections;

public class VideoPlayer : MonoBehaviour {

	void Start () {
		MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
		movie.Play ();
		movie.loop = true;
	}
}
