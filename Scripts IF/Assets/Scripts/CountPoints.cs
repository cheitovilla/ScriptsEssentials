using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountPoints : MonoBehaviour {

	//public GameObject Banana;
	public GameObject explosion;
	public TextMesh text;
	int i = 0;
	// Use this for initialization
	void Start()
	{
		text.text = "Score: " + i ;
	}

	// Update is called once per frame
	void Update () {
		text.text = "Score: " + i;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Banana")
		{
			i++;
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
			i++;
		}

	}
}
