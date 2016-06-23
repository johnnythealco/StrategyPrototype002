using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

public class GameAssetInput : MonoBehaviour
{
	public InputField NameInput;
	public InputField DescriptionInput;

	public Dropdown BaseTypeInput;

	void Start ()
	{
		getBaseTypes ();
	}


	void getBaseTypes ()
	{
		BaseTypeInput.ClearOptions ();
		BaseTypeInput.AddOptions (JKUtilities.BaseTypes);
	}

	public void AddGameAsset ()
	{
		var newAsset = new Asset (NameInput.text, DescriptionInput.text, (BaseType)BaseTypeInput.value);

		Game.Manager.GameAssets.Add (newAsset);
	}
	



}
