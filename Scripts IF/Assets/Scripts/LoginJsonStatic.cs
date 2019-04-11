using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;

public class LoginJsonStatic : MonoBehaviour {

	public InputField nickname; //el nick del usuario
	public InputField pass; //la contraseña
	public static LoginJsonStatic instancia; //creo la instancia
	void Awake()
	{
		instancia = this; //le asigno el valor
	}
	//Esta es la funcion para la validacion del usuario, si existe nos devuelbe un json con toda la informacion
	public void Validar()
	{
		string url = "http://inteligenciafutura.com/banco/login.php"; //el sitio que vamos a llamar
		WWWForm form = new WWWForm(); //Clase de ayuda para generar datos de formulario para publicar en servidores web utilizando las clases UnityWebRequest o WWW .
		form.AddField("nickname", nickname.text);//declaramos el campo para nick
		form.AddField("pass", pass.text);//declaramos el campo para password
		WWW www = new WWW(url, form);//creamos el formulario web
		StartCoroutine(WaitForRequest(www)); //iniciamos la corrutina
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www; //Cualquier función que incluya una instrucción yield se entiende que es una corrutina y el tipo de retorno 
		// check for errors access_token and token_type
		if (www.error == null)
		{
			Debug.Log("WWW : " + www.text);//Recibimos el json completo
//			var N = JSON.Parse(www.text);// lo formateamos y se lo pasamos a una variable //Comentareee ESTA LINEA PORQUE TIRABA WARNING
		}
		else
		{
			// Debug.Log("WWW Error: " + www.error);
		}
	}
}

