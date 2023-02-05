using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger241 : MonoBehaviour
{
	public GameObject Platform;
	public GameObject Block241;
	public GameObject PlatformTrigger;

	private void OnTriggerEnter(Collider other)
	{
		Platform.GetComponent<Animation>().Play("plattrigger241");
		Block241.GetComponent<Animation>().Play("Block241");
		Destroy(PlatformTrigger);
	}
}
