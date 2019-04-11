using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindUIText : MonoBehaviour {

	public Text my_text;

	void Start() {
		my_text = GameObject.Find("text_object_name").GetComponent<Text>();
	}

	public void ClickedButton() {
		my_text.text = "Testing...";
	}
}
