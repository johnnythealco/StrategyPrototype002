using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class JKUtilities
{
	
	public static List<string> BaseTypes {
		get {

			var result = new List<string> (); 

			var values = Enum.GetValues (typeof(BaseType));

			foreach (var item in values)
			{ 
				result.Add (item.ToString ());
			} 

			return result;
		}

	}



}