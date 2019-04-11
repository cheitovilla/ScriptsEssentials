using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour {

	//prefabs to instantiate
	public GameObject prefab1, prefab2, prefab3;
	//spawn prefabs once per 2 seconds
	public float spawnRate = 2f;
	//variable to set next spawn time
	float nextSpawn = 0f;
	//variable to contain random value
	int whatToSpawn;
	//Update to contain random value
	void Update()
	{
		if (Time.time > nextSpawn)
		{ //if time has come
			whatToSpawn = Random.Range(1, 4);//define random value between 1 and 4 
			Debug.Log(whatToSpawn);//display its value in console
			//instantiate a prefab depending on random value
			switch (whatToSpawn)
			{
			case 1:
				Instantiate(prefab1,transform.position,Quaternion.identity);
				break;
			case 2:
				Instantiate(prefab2, transform.position, Quaternion.identity);
				break;
			case 3:
				Instantiate(prefab3, transform.position, Quaternion.identity);
				break;
			}
			// set next spawn time
			nextSpawn = Time.time + spawnRate;
		}
		{
		}
	}
}
