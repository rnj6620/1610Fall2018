using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVars : MonoBehaviour
{

	string Name;

	public void Call()
	{
		Name = "Yuuri";
		print(Name);
	}

	public void Call(string newName)
	{
		print(newName);
		print(Name);
	}
	
}
