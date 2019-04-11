using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAndDisableGO : MonoBehaviour {

	public GameObject inicio;
	void OnMouseDown()
	{
		inicio.SetActive(false);
	}
}
