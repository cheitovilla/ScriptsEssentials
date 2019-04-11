using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginGet : MonoBehaviour {

	public InputField txtCorreo;
	public InputField txtClave;
	public void inicioSesion(){
		StartCoroutine (LoginApp());
	}
	IEnumerator LoginApp(){
		WWW con = new WWW("http://localhost:8095/LoginUnity/login.php?correo=" + WWW.EscapeURL(txtCorreo.text));
		yield return(con);
		Debug.Log (con.text);
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
