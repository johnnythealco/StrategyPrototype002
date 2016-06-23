using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
	}
	
}
