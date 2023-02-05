using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	private float speed = 10;
	private float jumpForce = 8f;
	private float gravity = 30f;
	private Vector3 moveDir = Vector3.zero;
  
    void Update()
    {
		CharacterController controller = gameObject.GetComponent<CharacterController>();

		if (controller.isGrounded)
		{
			moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDir = transform.TransformDirection(moveDir);
			moveDir *= speed;

			if(Input.GetButtonDown("Jump")){
				moveDir.y = jumpForce;
			}
		}

		moveDir.y -= gravity * Time.deltaTime;
		controller.Move(moveDir * Time.deltaTime);
        
    }
}
