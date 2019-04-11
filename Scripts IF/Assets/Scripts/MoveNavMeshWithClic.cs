using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveNavMeshWithClic : MonoBehaviour {

	public Transform destination;

	private NavMeshAgent agent;

	void Start()
	{
		agent = gameObject.GetComponent<NavMeshAgent>();

		agent.SetDestination(destination.position);
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray screenRay = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;
			if (Physics.Raycast(screenRay, out hit))
			{
				agent.SetDestination(hit.point);
			}
		}
	}
}
