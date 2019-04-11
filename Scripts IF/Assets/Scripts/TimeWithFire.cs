﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeWithFire : MonoBehaviour {

	public GameObject projectile;
	public float fireRate = 0.5F;
	private float nextFire = 0.0F;
	void Update() {
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			projectile = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
		}
	}
}
