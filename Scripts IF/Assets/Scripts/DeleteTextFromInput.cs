using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteTextFromInput : MonoBehaviour {

	public string tecla;
	public InputField texto;
	public void OnMouseDown()
	{
		Debug.Log(tecla);
		string value = texto.text;
		value = value.Substring(0, value.Length - 1);
		texto.text = value;
	}
}