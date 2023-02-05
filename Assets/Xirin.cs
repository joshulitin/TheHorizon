using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;


public class Xirin : MonoBehaviour
{
	[HideInInspector]
	public InputStr Input;
	public struct InputStr
	{
		public float LookX;
		public float LookZ;
		public float RunX;
		public float RunZ;
		public bool Jump;
	}

	public float Speed = 6f;
	public float JumpForce = 6f;

	protected bool Grounded;

	protected Rigidbody Rigidbody;
	protected Quaternion LookRotation;
	protected Animator Animator;

	private void Awake()
	{
		Rigidbody = GetComponent<Rigidbody>();
		Animator = GetComponentInChildren<Animator>();
	}

	private void Update()
	{
			Animator.SetBool("Grounded", Grounded);

			var localVelocity = Quaternion.Inverse(transform.rotation) * (Rigidbody.velocity / Speed);
			Animator.SetFloat("RunX", localVelocity.x);
			Animator.SetFloat("RunZ", localVelocity.z);
	}

	private void FixedUpdate()
	{
		var inputRun = Vector3.ClampMagnitude(new Vector3(Input.RunX, 0, Input.RunZ), 1);
		var inputLook = Vector3.ClampMagnitude(new Vector3(Input.LookX, 0, Input.LookZ), 1);

		Rigidbody.velocity = new Vector3(inputRun.x * Speed, Rigidbody.velocity.y, inputRun.z * Speed);
			
		if (inputLook.magnitude > 0.01f)				
			LookRotation = Quaternion.AngleAxis(Vector3.SignedAngle(Vector3.forward, inputLook, Vector3.up), Vector3.up);
		
		transform.rotation = LookRotation;

		//var Grounded = Physics.OverlapSphere(transform.position, 0.3f, 1).Length > 1;
		if (Physics.OverlapSphere(transform.position, 0.3f, 1).Length > 1)
		{
			Grounded = true;
		}
		if (Input.Jump)
		{
			if (Grounded)
			{
				Rigidbody.velocity = new Vector3(Rigidbody.velocity.x, JumpForce, Rigidbody.velocity.z);
				Grounded = false;
			}
		}
	}

	private void LateUpdate()
	{
		Animator.transform.localPosition = Vector3.zero;
		Animator.transform.localRotation = Quaternion.identity;
	}

	public void SlowCollision()
	{
		Speed = 2f;
	}
}
