using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {

	private Color mouseOverColor;
	private Color originalColor;
	private bool dragging = false;
	private float distance;

	void Start(){
		//mouseOverColor = GetComponent<Renderer> ().material.color;	
		//originalColor = GetComponent<Renderer> ().material.color;
	}

	void OnMouseEnter()
	{
		//mouseOverColor = Color.blue;
		mouseOverColor = GetComponent<Renderer> ().material.color = Color.blue;
	}

	void OnMouseExit()
	{
		//originalColor = Color.yellow;
		originalColor = GetComponent<Renderer> ().material.color = Color.yellow;
		//GetComponent().material.color = originalColor;
	}

	void OnMouseDown()
	{
		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
		dragging = true;
	}

	void OnMouseUp()
	{
		dragging = false;
	}

	void Update()
	{
		if (dragging)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 rayPoint = ray.GetPoint(distance);
			transform.position = rayPoint;
		}
	}
}
