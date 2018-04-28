using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerMovementController : MonoBehaviour {
	private CharacterController controller;
	private float speed = 89.0f;
	private float verticalVelocity = 0.0f;
	private float gravity = 12.0f;
	private Vector3 moveVector;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	// Update is called once per frame
	void Update () {


		moveVector = Vector3.zero;
		if(controller.isGrounded){
			verticalVelocity = 0.5f;
		}else{
			verticalVelocity -= gravity * Time.deltaTime;
		}
			
		controller.Move (Vector3.right * speed * Time.deltaTime);

	

		//X is left and right
		moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
		//Y is up and down
		moveVector.y = verticalVelocity;
		//Z is forward and backward
		moveVector.z = speed;
		//
		controller.Move(moveVector * Time.deltaTime);
	}
		
}
