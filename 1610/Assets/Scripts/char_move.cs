using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_move : MonoBehaviour {

public int MoveSpeed;
public float JumpHeight;

//Grounded
public Transform GroundCheck;
public float GroundCheckRadius;
public LayerMask WhatIsGround;
private bool Grounded;
//comment
/*
1
2
3
 */
	// Use this for initialization
	void Start () {
	print("Nope");
	}
	// FixedUpdate is called before Update
	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}	
	// Update is called once per frame
	void Update () {
		//Jumping
		if(Input.GetKeyDown(KeyCode.Space)&& Grounded)
		{
			Jump();
		}
	}
			public void Jump(){
			GetComponent<RigidBody2D>().velocity = new Vector2(GetComponent<RigidBody2D>().velocity.x, JumpHeight);
	}
}
