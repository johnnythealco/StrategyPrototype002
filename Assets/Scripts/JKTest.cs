using UnityEngine;
using System.Collections;

public class JKTest : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
//		logBaseTypes ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void logBaseTypes ()
	{
		foreach (var item in JKUtilities.BaseTypes)
		{
			Debug.Log (item);
		}
	}
}
