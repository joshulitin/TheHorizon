using UnityEngine;
using UnityEngine.UI; 

public class CameraMotor : MonoBehaviour {

	public Transform lookAt;
	public RectTransform virtualJoystickSpace;
	public RectTransform virtualJoystickJump;

	private Vector3 desiredPosition;
	private Vector3 offset;

	private Vector2 touchPos;
	private float swipeResistance = 300.0f;

	private float smoothSpeed = 7.5f;
	private float distance = 15.0f;
	private float yOffset = 3.5f;

	private bool isInsideVirtualJoystickSpace = false;
	private bool isInsideVirtualJoystickJump = false;

	private void Start() { 
		offset = new Vector3(0, yOffset, -1f * distance);
	}

	private void Update() {
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			SlideCamera(true);
		} else if (Input.GetKeyDown(KeyCode.RightArrow)) {
			SlideCamera(false);
		}

		if (Input.GetMouseButtonDown(0)) {
			if (RectTransformUtility.RectangleContainsScreenPoint(virtualJoystickSpace, Input.mousePosition))
			{
				isInsideVirtualJoystickSpace = true;
				
			}
			else if (RectTransformUtility.RectangleContainsScreenPoint(virtualJoystickJump, Input.mousePosition))
			{
				isInsideVirtualJoystickJump = true;

			}
			else
			{
				touchPos = Input.mousePosition;
			}
		}

		if (Input.GetMouseButtonUp(0)) {
			if (isInsideVirtualJoystickSpace || isInsideVirtualJoystickJump)
			{
				isInsideVirtualJoystickSpace = false;
				isInsideVirtualJoystickJump = false;
				return;
			}
			float swipeForce = touchPos.x - Input.mousePosition.x;
			if (Mathf.Abs(swipeForce) > swipeResistance) {
				if (swipeForce < 0) {
					SlideCamera(true);
				}
				else {
					SlideCamera(false);
				}
			}
		}

	}

	private void FixedUpdate() {
		desiredPosition = lookAt.position + offset;
		transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
		transform.LookAt(lookAt.position + Vector3.up);
	}

	public void SlideCamera(bool left) {
		if (left)
		{
			offset = Quaternion.Euler(0, 90, 0) * offset;
		}
		else
		{
			offset = Quaternion.Euler(0, -90, 0) * offset;
		}
	}
}
