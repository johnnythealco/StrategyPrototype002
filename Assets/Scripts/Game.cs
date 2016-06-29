using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

[System.Serializable]
public class Game : MonoBehaviour
{

	public List<Asset> GameAssets = new List<Asset> ();
	public static Game Manager = null;




	void Awake ()
	{
		if (Manager == null)
			Manager = this;
		else if (Manager != this)
			Destroy (gameObject);    
            
		DontDestroyOnLoad (gameObject);

		Debug.Log (Application.dataPath);
	}

	public void SaveAssetList ()
	{
		var JSON = JsonUtility.ToJson (this, true);
//		Debug.Log (JSON);
		File.WriteAllText (Application.dataPath + "GameAssets.JSON", JSON);
	}
	
}
