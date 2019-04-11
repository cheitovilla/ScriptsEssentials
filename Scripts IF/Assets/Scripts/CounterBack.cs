using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterBack : MonoBehaviour {

	float timeLeft = 3f;
	Text text;
	void Awake ()
	{
		text = GetComponent<Text> ();
	}
	void Update()
	{
		timeLeft -= Time.deltaTime;
		text.text = "00:" + "0" + Mathf.Round(timeLeft);
		if(timeLeft < 0)
		{
			//Application.LoadLevel("gameOver");
		}
	}
}
