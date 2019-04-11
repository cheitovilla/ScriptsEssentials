using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2dConSalto : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeigth;
	Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.velocity = new Vector2 (0,jumpHeigth);
		}


		if (Input.GetKey (KeyCode.D))
		{
			rb.velocity = new Vector2 (moveSpeed,rb.velocity.y);
		}

		if (Input.GetKey (KeyCode.A))
		{
			rb.velocity = new Vector2 (-moveSpeed,rb.velocity.y);
		}
	}
}
