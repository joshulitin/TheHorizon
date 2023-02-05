using UnityEngine;

public class Motor : MonoBehaviour {

	public float moveSpeed = 5.0f;
	public float drag = 0.5f;
	public float terminalRotationSpeed = 25.0f;
	public VirtualJoystick moveJoystick;

	
	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;
	
	public LayerMask groundLayers;
	public float jumpForce = 7f;
	public SphereCollider col; 

	private Rigidbody controller;
	private Transform camTransform;

	private void Start() {
		
		controller = GetComponent<Rigidbody>();
		controller.maxAngularVelocity = terminalRotationSpeed;
		controller.drag = drag;
		col = GetComponent<SphereCollider>();

		camTransform = Camera.main.transform;
	}

	private void Update() {

		Vector3 dir = Vector3.zero;
		dir.x = Input.GetAxis("Horizontal");
		dir.z = Input.GetAxis("Vertical");

		if (dir.magnitude > 1) {
			dir.Normalize();
		}

		if (moveJoystick.InputDirection != Vector3.zero) {
			dir = moveJoystick.InputDirection;
		}

		// Rotate our direction vector with the camera
		Vector3 rotatedDir = camTransform.TransformDirection(dir);
		rotatedDir = new Vector3(rotatedDir.x, 0, rotatedDir.z);
		rotatedDir = rotatedDir.normalized * dir.magnitude;

		controller.AddForce(rotatedDir * moveSpeed);

		
	}

	public void Jump() {
		if (IsGrounded())
		{
			controller.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
			
		}
	}

	private bool IsGrounded()
	{
		return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x,
			col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
		
	}
}
