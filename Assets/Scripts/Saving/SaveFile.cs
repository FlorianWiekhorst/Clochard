using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveFile  {

	public static SaveFile current;
	public string testString;

	public SaveFile(){
		testString = "Poop";
	}

}
