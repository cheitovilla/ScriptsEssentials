using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectNeverDestroy : MonoBehaviour {

	public string PlayerName = "";
	public static ObjectNeverDestroy Instance;

	void Awake()
	{
		if(Instance)
		{
			Destroy (gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
			Instance= this;
		}
	}
		
}
