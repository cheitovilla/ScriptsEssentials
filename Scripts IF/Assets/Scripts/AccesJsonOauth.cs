using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
//Descargar la libreria que se usa que es Simple JSON y es la carpeta llamada SimpleJSON-master.zip 
//link: https://github.com/Bunny83/SimpleJSON


public class AccesJsonOauth : MonoBehaviour {

	public InputField username;
	//public Post level; ojo aquí

	void Start()
	{
		string url = "http://localhost:8095/laravel/api/public/oauth/token";
		WWWForm form = new WWWForm();
		form.AddField("client_id", 1);
		form.AddField("client_secret", "16R5AiOFWiEnPaL2O0llTYHXnnvtw4EKq5cJT0FY");
		form.AddField("grant_type", "password");
		form.AddField("username", username.text);
		form.AddField("password", "123456");
		WWW www = new WWW(url, form);
		StartCoroutine(WaitForRequest(www));
	}
	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		// check for errors access_token and token_type
		if (www.error == null)
		{
			string json =  www.text ;
			JSONNode data = JSON.Parse(json);
			string action = data["access_token"].Value;
			//string speech = data["result"]["fulfillment"]["speech"].Value;
			Debug.Log("Post: " + action );
			//Debug.Log("WWW Ok!: " + www.data);
		}
		else
		{
			// Debug.Log("WWW Error: " + www.error);
		}
	}
}
