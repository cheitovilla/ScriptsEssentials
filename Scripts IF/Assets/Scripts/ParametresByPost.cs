using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametresByPost : MonoBehaviour {

	void Start()
	{
		string url = "http://localhost:8095/TestApi/ensayo.php";
		WWWForm form = new WWWForm();
		form.AddField("var1", "mierda");
		WWW www = new WWW(url, form);
		StartCoroutine(WaitForRequest(www));
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.text);
		}
		else
		{
			Debug.Log("WWW Error: " + www.error);
		}
	}
}

/* 
		<?php
	if (isset($_POST["var1"])) {
	echo "Received ". $_POST["var1"]. " success!";
	exit();
	} else {
	http_status_code(400);
	echo "Request Failed";
	}

*/