using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
using UnityEngine.SceneManagement;

public class CompletingOauth : MonoBehaviour {

	public InputField username;
	public InputField password;
//	public Post level; OJO AQUÍ
	public Text txtRespuesta;
	public void Iniciar()
	{
		string url = "http://54.202.219.27/laravel/api/public/oauth/token";
		WWWForm form = new WWWForm();
		form.AddField("client_id", 1);
		form.AddField("client_secret", "CivdInNUrz7NTtP8EftIQtE7IHFmaBVLr1O4e4Yz");
		form.AddField("grant_type", "password");
		form.AddField("username", username.text);
		form.AddField("password", password.text);
		WWW www = new WWW(url, form);
		StartCoroutine(WaitForRequest(www));
	}
	public void salir(){
		SceneManager.LoadScene("post1", LoadSceneMode.Single);
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
			StartCoroutine (DatosApp(action));
			//Debug.Log("WWW Ok!: " + www.data);
		}
		else
		{
			txtRespuesta.text = "Usuario o clave incorrectos";
			//Debug.Log("WWW Error: " + www.error);
		}
	}
	/////recibo la respuesta
	IEnumerator DatosApp( string token){
		//WWW con = new WWW("http://54.202.219.27/DatosUnity/datos.php?correo=" + username.text + "&clave=" + password.text);
		//yield return(con);
		//Debug.Log (con.text);
		//txtRespuesta.text = con.text;
		//if(con.text == "Bienvenido"){
		//	Debug.Log ("Eres el mejor Jaime");
		//}
		//////////////////////////  
//		WWWForm form = new WWWForm(); //ESTA TAMBIEN LA COMENTAREE PROQUE TIRABA WARNING
		Dictionary<string, string> headers = new Dictionary<string,string>();
		//Dictionary<string, string> headers = form.headers;
//		string auth = "Token"; //COMENTARE ESTA LINEA PORQUE TIRABA WARNING
		headers.Add("Authorization", "Bearer "+ token);
		WWW www = new WWW("http://54.202.219.27/laravel/api/public/api/posts", null, headers);
		yield return(www);
		Debug.Log (www.text);
		/// /////////////////////
	}
}
