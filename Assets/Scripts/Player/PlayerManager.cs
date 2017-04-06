using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerManager : MonoBehaviour {

	public int health;
	public float stamina;
	public Text staminaText;
	public Vector3 cacheSpeed;
	public CharacterController playerController;



	void Start(){
		playerController = GetComponent<CharacterController> ();
		staminaText.text = stamina.ToString ();
		cacheSpeed = playerController.velocity;
	}

	void Update(){
		if(health == 0){		//Life
			GameOver ();
		}


		if (Input.GetButton ("Run") && transform.GetComponent<CharacterController>().velocity.magnitude != 0f) {
			StopCoroutine (FillStamina());
			StartCoroutine (LoseStamina());
			if (stamina == 0.0f) {
				playerController.enabled = false;
				Invoke ("ResetStamina", 3.0f);
			}
		} else {
			StopCoroutine (LoseStamina());
			StartCoroutine (FillStamina());
		}
	}

	void GameOver(){
		Debug.Log ("GameOver");
	}
	void ResetStamina(){
		stamina = 100.0f;
		staminaText.text = stamina.ToString("N0");
		playerController.enabled = true;
	}

	IEnumerator FillStamina(){
		yield return new WaitForSeconds (1);
		stamina = Mathf.Clamp (stamina + (Time.deltaTime * 10), 0, 100);
		staminaText.text = stamina.ToString ("N0");
	}
	IEnumerator LoseStamina(){
		stamina = Mathf.Clamp (stamina - (Time.deltaTime * 10), 0, 100);
		staminaText.text = stamina.ToString ("N0");
		yield return null;
	}

}
