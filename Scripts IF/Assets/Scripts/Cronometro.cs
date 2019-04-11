using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cronometro : MonoBehaviour {

	public float timeLeft = 50.0f;
	public TextMesh texto;
	void Update()
	{
		timeLeft -= Time.deltaTime;

		if (timeLeft <= 0.0f)
		{
			// End the level here.
			//GetComponent().text = "You ran out of time";
		}
		else
		{
			//GetComponent().text = "Time left = " + (int)timeLeft + " seconds";
			texto.text = "Time =" + (int)timeLeft;
		}

	}
}
