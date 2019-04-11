using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

	void Update () {
		//Representación de rayos,Un rayo es una línea infinita que comienza en el origen y va en alguna dirección .
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		//Definimos el origen del rayo y la direccion multiplicada por el tamaño que queremos y el color
		Debug.DrawRay (ray.origin, ray.direction * 100, Color.cyan);
		RaycastHit hit; //Estructura utilizada para obtener información de un raycast.
		if(Input.GetMouseButton(0)){ //Si dejamos presionado clic izquierdo
			if(Physics.Raycast(ray, out hit) == true ){ //Lanza un rayo, desde el punto origin, en dirección direction, de longitud maxDistance, contra todos los colisionadores en la escena.
				Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red); //Lo dibujamos de rojo
				Debug.Log("El rayo toca con " + hit.transform.gameObject.name); //Si colisiona nos muestra el nombre del objeto
			}
		}
	}
}