using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovie : MonoBehaviour {

    void Start () {
        
            
       Renderer r = GetComponent<Renderer>();
       MovieTexture movie = (MovieTexture)r.material.mainTexture;
       AudioSource aud = GetComponent<AudioSource>();
       //aud.clip = movie.audioClip;

        movie.Play();
        movie.loop = true;
        aud.Play();
      }
}

