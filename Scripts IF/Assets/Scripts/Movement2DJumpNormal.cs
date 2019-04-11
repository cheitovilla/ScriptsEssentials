using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2DJumpNormal : MonoBehaviour {
	private Rigidbody2D playerRB;
	private Animator playerAnim;
	[SerializeField]
	private float playerSpeed;
	// Use this for initialization
	void Start () {
		playerRB = GetComponent<Rigidbody2D>();
		playerAnim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		PlayerMovement ();
		PlayerSaltar ();
	}

	public void PlayerMovement(){
		if(Input.GetAxis("Horizontal") > 0){
			playerRB.velocity = new Vector2(playerSpeed,playerRB.velocity.y);
			transform.localScale = new Vector3(1,1,1);
		}
		if(Input.GetAxis("Horizontal") < 0){
			playerRB.velocity = new Vector2(-playerSpeed,playerRB.velocity.y);
			transform.localScale = new Vector3(-1,1,1);
		}
		playerAnim.SetFloat("speed",Mathf.Abs(playerRB.velocity.x));
	}
	public void PlayerSaltar(){
		if(Input.GetKeyDown("space")){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
		}
	}
}
