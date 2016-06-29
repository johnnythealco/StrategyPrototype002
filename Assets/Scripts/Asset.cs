using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[System.Serializable]
public class Asset : System.Object
{
	public string name;
	public string description;
	public string baseType;

	public Asset (string _name, string _description, string _baseType)
	{
		this.name = _name;
		this.description = _description;
		this.baseType = _baseType;
	}

}
//
//public enum BaseType
//{
//	Resource = 0,
//	Structure = 1,
//	Character = 2,
//	Location = 3,
//	Item = 4,
//	Unit = 5
//
//
//}
//
//public enum ResourceType
//{
//	Strategic = 0,
//	Commodity = 1
//
//}
//
//public enum StructureType
//{
//	Planetary = 0,
//	Space = 1
//}
//
//public enum CharacterType
//{
//	Playable = 0,
//	NonPlayable = 1
//}
//
//public enum LocationType
//{
//	Planetary = 0,
//	Space = 1
//}
//
//public enum ItemType
//{
//	Strategic = 0,
//	Commodity = 1
//}
//
//public enum UnitType
//{
//	Ground = 0,
//	Space = 1
//}
