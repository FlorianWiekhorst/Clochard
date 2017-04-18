using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerManager : MonoBehaviour {

	public float health;
	public float stamina;
	public float hunger;
	public Text staminaText,healthText,hungerText;
	public Vector3 cacheSpeed;
	public CharacterController playerController;
	GameObject staminaObj,healthObj,hungerObj;
	GameObject playerHUD;
	GameObject gameoverscreen;



	void Start(){
		playerHUD = GameObject.Find ("PlayerHUD");
		gameoverscreen = playerHUD.transform.Find("GameOverScreen").gameObject;
		playerController = GetComponent<CharacterController> ();
		staminaObj = GameObject.Find ("StaminaText");
		healthObj = GameObject.Find ("HealthText");
		hungerObj = GameObject.Find ("HungerText");

		hungerText = hungerObj.GetComponent<Text> ();
		hungerText.text = hunger.ToString (); 

		staminaText = staminaObj.GetComponent<Text> ();
		staminaText.text = stamina.ToString ();

		healthText = healthObj.GetComponent<Text> ();
		healthText.text = health.ToString ();

		cacheSpeed = playerController.velocity;
		InvokeRepeating("LoseHunger",4.0f,4.0f);

	}

	void Update(){

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
		gameoverscreen.SetActive (true);
		Time.timeScale = 0f;
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

	void LoseHunger(){
		hunger = Mathf.Clamp(hunger - 100f,0 , 100);
		hungerText.text = hunger.ToString ();
		if(hunger == 0){
			StartCoroutine (LoseHealth());
		}
	}
	IEnumerator LoseHealth(){
		health = Mathf.Clamp (health - 10.0f, 0, 100);
		healthText.text = health.ToString ();
		if(health == 0){		//Life
			GameOver ();
		}
		yield return null;
	}




}
