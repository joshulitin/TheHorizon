using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DitzeGames.MobileJoystick;
namespace DitzeGames.MobileJoystick
{
	public class XirinController : MonoBehaviour
	{
		protected Joystick Joystick;
		protected Button JumpButton;
		protected TouchField TouchField;
		public Xirin Xirin;

		//Camera Control
		public Vector3 CameraPivot;
		public float CameraDistance;

		protected const float RotationSpeed = 6;

		protected float InputRotationX;
		protected float InputRotationY;
		void Awake()
		{
			Joystick = FindObjectOfType<Joystick>();
			TouchField = FindObjectOfType<TouchField>();
			Xirin = GetComponent<Xirin>();
			JumpButton = FindObjectOfType<Button>();
		}
			
		void Update()
		{
			InputRotationX = (InputRotationX + TouchField.TouchDist.x * RotationSpeed * Time.deltaTime) % 360f;
			InputRotationY = Mathf.Clamp(InputRotationY - TouchField.TouchDist.y * RotationSpeed * Time.deltaTime, -88f, 88f);

			var characterForward = Quaternion.AngleAxis(InputRotationX, Vector3.up) * Vector3.forward;
			var characterLeft = Quaternion.AngleAxis(InputRotationX + 90, Vector3.up) * Vector3.forward;

			var runDirection = characterForward * (Input.GetAxis("Vertical") + Joystick.AxisNormalized.y) + characterLeft * (Input.GetAxis("Horizontal") + Joystick.AxisNormalized.x);
			var lookDirection = Quaternion.AngleAxis(InputRotationY, characterLeft) * characterForward;

			Xirin.Input.RunX = runDirection.x;
			Xirin.Input.RunZ = runDirection.z;
			Xirin.Input.LookX = lookDirection.x;
			Xirin.Input.LookZ = lookDirection.z;
			Xirin.Input.Jump = JumpButton.Pressed;

			var characterPivot = Quaternion.AngleAxis(InputRotationX, Vector3.up) * CameraPivot;

			StartCoroutine(setCamera(lookDirection, characterPivot));
		}

		private IEnumerator setCamera(Vector3 lookDirection, Vector3 characterPivot)
		{
			yield return new WaitForFixedUpdate();
			// Camera Values
			Camera.main.transform.position = (transform.position + characterPivot) - lookDirection * CameraDistance;
			Camera.main.transform.rotation = Quaternion.LookRotation(lookDirection, Vector3.up);
		}
	}
}	