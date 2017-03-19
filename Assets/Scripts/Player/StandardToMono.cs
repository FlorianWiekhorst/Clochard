using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using Random = UnityEngine.Random;

namespace UnityStandardAssets{

	public class StandardToMono : MonoBehaviour {

		public GameObject player;
		public FirstPersonController controller;

		// Use this for initialization
		void Start () {
			player = GameObject.Find ("_Player");
		}
		
		// Update is called once per frame
		void Update () {
			
		}
	}
}