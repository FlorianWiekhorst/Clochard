using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneDestroyer : MonoBehaviour {
    //Destroys any particle system clones created

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Particle System(Clone)")
        {
            Destroy(gameObject, 5);
            //Destroy(instance.gameObject, 5);
        }
    }
}
