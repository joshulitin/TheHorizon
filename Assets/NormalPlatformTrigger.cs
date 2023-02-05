using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalPlatformTrigger : MonoBehaviour
{
	public GameObject closedDoor;

	private void OnTriggerEnter(Collider other)
	{
		closedDoor.GetComponent<Animation>().Play("stage11anim");
	}
}
