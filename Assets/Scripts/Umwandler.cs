using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Dieses Script zerstört bei Collision mit dem Spieler das Objekt und wandelt es in andere Objekte um. Dabei ertönt ein Sound
//Manchmal fallen Objekte durch den Boden endlos in die Tiefe
public class Umwandler : MonoBehaviour {

    public GameObject[] MyPrefabs;
    public AudioClip[] MySounds;
    public ParticleSystem tempCollisionParticle;

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

            tempCollisionParticle = Instantiate(tempCollisionParticle, transform.position, Quaternion.identity);
            tempCollisionParticle.Play();
            
            
            int randomSoundIndex = Random.Range(0, MySounds.Length);
            AudioSource.PlayClipAtPoint(MySounds[randomSoundIndex], transform.position);
  
            

            for (int i=0; i<MyPrefabs.Length; i++) {
                Instantiate(MyPrefabs[i], transform.position, Quaternion.identity);
            }
            
            Debug.Log("You Hit Me");
            Destroy(gameObject);

        }

    }

   
}
