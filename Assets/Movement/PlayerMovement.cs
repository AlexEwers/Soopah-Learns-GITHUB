using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	public CharacterController2D controller;
	private Vector3 s;


	public float runSpeed = 40f;
	float horizontalMove = 0f;
	bool crouch = false;
	bool jump = false;

	// Update is called once per frame
	void Update() {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;

			Debug.Log(Input.GetButtonDown("Jump"));
		}


		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

		if (Input.GetKey(KeyCode.Space)) //Raycast
		{
			RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), 10f);
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.right) * 10f, Color.green);

			Debug.Log("hit");
		}

	}

	

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
		
	}
}
