using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : MonoBehaviour {

	public float speed = 5f;
	public float jumpSpeed = 8f;
	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	void Update()
	{
		//si preciono la tecla espacio doy un golpe
		if (Input.GetButton("Fire1")) //Input.GetKeyDown(KeyCode.Space)
		{
			if (null != anim)
			{
				Debug.Log("Playing anim");
				anim.Play("golpe");
			}
		}

		//si presiono hacia los lados
		if (Input.GetKey(KeyCode.D))
		{
			if (null != anim)
			{
				Debug.Log("Playing anim");
				anim.Play("walk");
			}
		}

	}
}
