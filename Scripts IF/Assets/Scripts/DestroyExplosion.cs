using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour {

	public float tiempoVida = 5.0f;

	void Awake()
	{
		Destroy(this.gameObject, tiempoVida);
	}
}
