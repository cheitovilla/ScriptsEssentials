using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WriteAndRead : MonoBehaviour {

	public string txtFile = "datos.txt";
	string txtContents;
	// Use this for initialization
	void Start () {
		System.IO.File.WriteAllText("Assets/Resources/datos.txt", "mierda");
		TextAsset txtAssets = (TextAsset)Resources.Load(txtFile);
		txtContents = txtAssets.text;
	}
	// Update is called once per frame
	void Update () {
		Debug.Log (txtContents);
	}
}