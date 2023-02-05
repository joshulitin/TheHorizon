using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger4101 : MonoBehaviour
{
	public GameObject Platform;
	public GameObject Block4101;
	public GameObject PlatformTrigger;

	private void OnTriggerEnter(Collider other)
	{
		Platform.GetComponent<Animation>().Play("PlatformTrigger4101");
		Block4101.GetComponent<Animation>().Play("Block4101");
		Destroy(PlatformTrigger);
	}
}
