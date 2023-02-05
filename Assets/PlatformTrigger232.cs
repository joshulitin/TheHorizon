using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger232 : MonoBehaviour
{
	public GameObject Platform2;
	public GameObject Block232;
	public GameObject PlatformTrigger2;

	private void OnTriggerEnter(Collider other)
	{
		Platform2.GetComponent<Animation>().Play("plattrigger232");
		Block232.GetComponent<Animation>().Play("Block232");
		Destroy(PlatformTrigger2);
	}
}
