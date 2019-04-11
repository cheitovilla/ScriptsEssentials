using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

	public Transform target ; //el enemigo objetivo
	public int moveSpeed = 3; //mover velocidad
	public int rotationSpeed = 3; //velocidad de giro
	public float attackThreshold = 1.5f; // distancia dentro de la cual atacar
	public int chaseThreshold = 10; // distancia dentro de la cual comenzar persiguiendo
	public int giveUpThreshold = 20; // distancia a partir del cual se da por vencido AI
	public int attackRepeatTime = 1; // retardo entre ataques cuando dentro del rango

	public bool chasing = false;
	//public Time.time attackTime ;
	public float attackTime = 0f;
	public float distance = 0f;

	public Transform myTransform ; //datos actuales de transformación de este enemigo

	void Awake (){
		myTransform = transform; //Transformación de caché de datos para facilitar el acceso / rendimiento
	}

	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("Player").transform; //apuntar al jugador
	}

	// Update is called once per frame
	void Update () {
		// comprobar la distancia al objetivo cada cuadro:
		distance = (target.position - myTransform.position).magnitude;

		if (chasing) {

			//girar para mirar el jugador
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
				Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);

			//avanzar hacia el jugador
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

			// renunciar, si es muy lejos de la meta:
			if (distance > giveUpThreshold) {
				chasing = false;
			}

			// ataque, si lo suficientemente cerca, y si el tiempo está bien:
			if (distance < attackThreshold && Time.time > attackRepeatTime) {

				target.SendMessage("ApplyDamage",10);
				// Attack! (llame a cualquier función de ataque que te gusta aquí)
			}
			if (distance < attackThreshold) {
				moveSpeed=0;
				//parar cuando lo suficientemente cerca
			}

			attackTime = Time.time+ attackRepeatTime;
		}

		else {
			// actualmente no perseguía.

			// empezar a perseguir si el objetivo se acerca lo suficiente
			if (distance < chaseThreshold) {
				chasing = true;
			}
		}

	}
}
