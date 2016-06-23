using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[System.Serializable]
public class Asset : System.Object
{
	public string name;
	public string description;
	public BaseType baseType;

	public Asset (string _name, string _description, BaseType _baseType)
	{
		this.name = _name;
		this.description = _description;
		this.baseType = _baseType;
	}




}

public enum BaseType
{
	Resource = 0,
	Structure = 1,
	Character = 2,
	Location = 3,
	Item = 4,
	Unit = 5


}
