﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAndRotatonwithKeyboard : MonoBehaviour {

	float deltaRotation = 30f;
	float deltaMovement = 10f;

	// Update is called once per frame
	void Update () {
		Rotate ();
		Movement ();
	}
	void Rotate(){
		if(Input.GetKey(KeyCode.Q)){
			transform.Rotate(new Vector3 (0f,-deltaRotation,0f) * Time.deltaTime );
		}else if( Input.GetKey(KeyCode.E)){
			transform.Rotate(new Vector3 (0f,deltaRotation,0f) * Time.deltaTime );
		}
	}
	void Movement(){
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * deltaMovement * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.back * deltaMovement * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * deltaMovement * Time.deltaTime);
		} else if(Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * deltaMovement * Time.deltaTime);
		}
	}
}