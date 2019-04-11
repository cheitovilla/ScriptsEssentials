using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSlow : MonoBehaviour {

	Vector3 right = new Vector3(0, 0, -1f); //Vector in the direction you want to move in.
	void Update()
	{
		//Using update.
		StartCoroutine(smooth_move(right, 0.01f)); //Calling the coroutine.
	}

	IEnumerator smooth_move(Vector3 direction, float speed)
	{
		float startime = Time.time;
		Vector3 start_pos = transform.position; //Starting position.
		Vector3 end_pos = transform.position + direction; //Ending position.
		while (start_pos != end_pos && ((Time.time - startime) * speed) < 1f)
		{
			float move = Mathf.Lerp(0, 1, (Time.time - startime) * speed);
			transform.position += direction * move;
			yield return null;
		}
	}
}
