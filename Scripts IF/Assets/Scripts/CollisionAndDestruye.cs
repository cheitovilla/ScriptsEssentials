using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAndDestruye : MonoBehaviour {

	//public GameObject Banana;
	public GameObject explosion;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Banana")
		{
			Debug.Log("why wont you work ;_;");
			Instantiate(explosion, transform.position, transform.rotation);
			//Destroy(Banana);
			Destroy(GameObject.FindWithTag("Banana"));
		}

		if (other.gameObject.tag == "Patata")
		{
			Debug.Log("why wont you work ;_;");
			Instantiate(explosion, transform.position, transform.rotation);
			//Destroy(Banana);
			GameObject.FindWithTag("Patata");
		}

	}
}
