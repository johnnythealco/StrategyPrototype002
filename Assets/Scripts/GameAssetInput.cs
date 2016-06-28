using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using System;

public class GameAssetInput : MonoBehaviour
{
	public InputField NameInput;
	public InputField DescriptionInput;

	public Dropdown BaseTypeInput;
	public Dropdown SubTypeAInput;

	//	public delegate void baseTypeChanged (Dropdown _dropdown);

	//	List<string> BaseTypes {
	//		get {
	//
	//			var result = new List<string> ();
	//
	//			var values = Enum.GetValues (typeof(BaseType));
	//
	//			foreach (var item in values)
	//			{
	//				result.Add (item.ToString ());
	//			}
	//
	//			return result;
	//		}
	//
	//	}

	void Start ()
	{
		getBaseTypes ();
		setSubTypeA (0);

		BaseTypeInput.onValueChanged.AddListener (setSubTypeA);

	}




	void getBaseTypes ()
	{
		BaseTypeInput.ClearOptions ();
		BaseTypeInput.AddOptions (JKUtilities.BaseTypes);
	}

	public void AddGameAsset ()
	{
		var newAsset = new Asset (NameInput.text, DescriptionInput.text, BaseTypeInput.captionText.text);

		Game.Manager.GameAssets.Add (newAsset);
	}

	public void setSubTypeA (int _value)
	{
		string _baseType = BaseTypeInput.captionText.text;
		switch (_baseType)
		{
		case "Resource":
			SubTypeAInput.ClearOptions ();
			SubTypeAInput.AddOptions (JKUtilities.ResourceTypes);
			break;
		case "Structure":
			SubTypeAInput.ClearOptions ();
			SubTypeAInput.AddOptions (JKUtilities.StructureTypes);
			break;
		case "Character":
			SubTypeAInput.ClearOptions ();
			SubTypeAInput.AddOptions (JKUtilities.CharacterTypes);
			break;
		case "Location":
			SubTypeAInput.ClearOptions ();
			SubTypeAInput.AddOptions (JKUtilities.LocationTypes);
			break;
		case "Item":
			SubTypeAInput.ClearOptions ();
			SubTypeAInput.AddOptions (JKUtilities.ItemTypes);
			break;
		case "Unit":
			SubTypeAInput.ClearOptions ();
			SubTypeAInput.AddOptions (JKUtilities.UnitTypes);
			break;

		}
	}

	



}
