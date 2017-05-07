using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Dieses Script zerstört bei Collision mit dem Spieler das Objekt und wandelt es in andere Objekte um. Dabei ertönt ein Sound
public class Umwandler : MonoBehaviour {

    public GameObject[] MyPrefabs;
    public AudioClip MySound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(MySound, transform.position);

            for (int i=0; i<MyPrefabs.Length; i++) {
                Instantiate(MyPrefabs[i], transform.position, Quaternion.identity);
            }
            
            Debug.Log("You Hit Me");
            Destroy(gameObject);

        }

    }

   
}
