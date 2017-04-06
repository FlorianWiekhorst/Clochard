using UnityEngine;
using System.Collections;

[CreateAssetMenu]
public class Item : ScriptableObject {

	
	public Sprite sprite;
	public GameObject prefab; 
	public bool stackable;
	public bool isEdible;
	public int bonus_health;

}
