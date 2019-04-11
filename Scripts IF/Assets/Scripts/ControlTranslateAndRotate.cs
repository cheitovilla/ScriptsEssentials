using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTranslateAndRotate : MonoBehaviour {

	public Transform target;
	public float speed;
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	void Start()
	{
		transform.Rotate(15 * Time.deltaTime, 0, 0);
	}
	void Update()
	{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		//transform.Rotate(15 * Time.deltaTime, 0, 0);
		//transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
		if (transform.rotation.eulerAngles.y < 90)
		{
			transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
		}
		else
		{
			//  Debug.Log("NO Estoy en el angulo");
		}

	}
}
