using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

[System.Serializable]
public static class SaveManager {

	public static List<SaveFile> savedGames = new List<SaveFile>();

	public static void Save(){
		//FOR LATER PURPOSES
		if(!Directory.Exists(Path.Combine(Application.dataPath,"Assets/SaveFiles"))){
			Directory.CreateDirectory ("SaveFiles");
		}

		savedGames.Add(SaveFile.current);
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Path.Combine(Application.dataPath , "../SaveFiles/savegame.clo"));
		bf.Serialize(file, SaveManager.savedGames);
		file.Close();
	}

}
