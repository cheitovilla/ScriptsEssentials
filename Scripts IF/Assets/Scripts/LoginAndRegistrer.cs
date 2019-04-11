using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginAndRegistrer : MonoBehaviour {

	public InputField txtCorreo;
	public InputField txtClave;
	public string nombreUsuario;
	//campos de registro
	public InputField txtNombre;
	public InputField txtApellidos;
	//campo de respuesta
	public Text txtRespuesta;
	//objeto a ocultar
	public GameObject conjunto;
	public GameObject botonEntrar;
	public GameObject botonRegistro;
	public GameObject ocultarTodos;
	public int puntosJugador;
	public bool iniciarSesion = false;
	public void Start(){
		conjunto.SetActive (false);
		botonRegistro.SetActive (false);
	}
	public void inicioSesion(){
		StartCoroutine (LoginApp());
		StartCoroutine (DatosApp());
	}
	public void CrearRegistro(){
		conjunto.SetActive (true);
		botonRegistro.SetActive (true);
		botonEntrar.SetActive (false);
	}
	public void RegistrarUsu(){
		conjunto.SetActive (false);
	}
	public void RegistroCompleto(){
		Debug.Log ("Estoy guardando");
		StartCoroutine (RegistrarApp());
	}
	IEnumerator LoginApp(){
		WWW con = new WWW("http://localhost:8095/LoginUnity/login.php?correo=" + WWW.EscapeURL(txtCorreo.text) + "&clave=" + WWW.EscapeURL(txtClave.text ));
		yield return(con);
		Debug.Log (con.text);
		if(con.text == "Bienvenido"){
			Debug.Log ("Eres el mejor carlos");
		}
	}
	IEnumerator DatosApp(){
		WWW con = new WWW("http://localhost:8095/LoginUnity/datosUsuario.php?correo=" + WWW.EscapeURL(txtCorreo.text) );
		yield return(con);
		Debug.Log (con.text);
		string[] nDatos = con.text.Split('|');
		if(nDatos.Length != 2){
			print("Error en la consulta");
		}else{
			nombreUsuario = nDatos[0];
			puntosJugador = int.Parse(nDatos[1]);
			Debug.Log("Bienvenido Player:" + nombreUsuario);
			txtRespuesta.text = "Bienvenido Player:" + nombreUsuario;
			iniciarSesion = true;
			ocultarTodos.SetActive (false);
		}

	}
	IEnumerator RegistrarApp(){
		WWW con = new WWW("http://localhost:8095/LoginUnity/registro.php?correo=" + txtCorreo.text + "&clave=" + WWW.EscapeURL(txtClave.text) + "&nombre=" + WWW.EscapeURL(txtNombre.text) + "&apellidos=" + WWW.EscapeURL(txtApellidos.text) );
		yield return(con);
		Debug.Log (con.text);
		if(con.text == "Ok"){
			//Application.LoadLevel(0);
			SceneManager.LoadScene ("La_Scena_Sgte");
		}
	}
}
