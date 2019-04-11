using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoverToClicPoint : MonoBehaviour {

	public NavMeshAgent agent;//Los componentes NavMeshAgent le ayudarán a usted crear personajes que se eviten a ellos mismos mientras se mueven hacia su objetivo.

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();//Todos los Gameobjects tienen algún componente, bien sea un componente Transform, Rigidbody,Collider, Scripts etc 
		//utilizando getcomponent puedes acceder a esos componentes y a sus propiedades.
	}

	void Update() 
	{
		if (Input.GetMouseButtonDown(0)) { //Input del Teclado
			//Ray que será, desde donde hacemos click, vease en un punto de la pantalla que dentro del mundo 3D será desde la cámara principal del videojuego,
			// hacia adelante al infinito hasta colisionar con algo
			RaycastHit hit;//RaycastHit será el objeto con el que colisiona este rayo.

			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) { //Con ScreenPointToRay puedes calcular un rayo que va desde la camera y apunta donde estas
				agent.destination = hit.point; //a donde se movera
			}
		}
	}
}
