﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitives : MonoBehaviour {

	void Start ()
	{
		GameObject plane = GameObject.CreatePrimitive (PrimitiveType.Plane);
		plane.transform.position = new Vector3 (0, 0, 0);
		GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube.transform.position = new Vector3 (0, 0.5F, 0);
		GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		sphere.transform.position = new Vector3 (0, 1.5F, 0);
		GameObject capsule = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		capsule.transform.position = new Vector3 (2, 1, 0);
		GameObject cylinder = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		cylinder.transform.position = new Vector3 (-2, 1, 0);
	}
}