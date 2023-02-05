using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger251 : MonoBehaviour
{
	public GameObject Platform;
	public GameObject Block251;
	public GameObject PlatformTrigger;

	private void OnTriggerEnter(Collider other)
	{
		Platform.GetComponent<Animation>().Play("PlatformTrigger251");
		Block251.GetComponent<Animation>().Play("Block251");
		Destroy(PlatformTrigger);
	}
}
