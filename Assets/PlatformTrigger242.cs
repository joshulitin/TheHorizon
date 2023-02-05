using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger242 : MonoBehaviour
{
	public GameObject Platform2;
	public GameObject Block242;
	public GameObject PlatformTrigger2;

	private void OnTriggerEnter(Collider other)
	{
		Platform2.GetComponent<Animation>().Play("plattrigger242");
		Block242.GetComponent<Animation>().Play("MovingPlatform241");
		Destroy(PlatformTrigger2);
	}
}
