using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger231 : MonoBehaviour
{
	public GameObject Platform;
	public GameObject BlockOne;
	public GameObject PlatformTrigger;

	private void OnTriggerEnter(Collider other)
	{
		Platform.GetComponent<Animation>().Play("plattrigger231");
		BlockOne.GetComponent<Animation>().Play("Block231");
		Destroy(PlatformTrigger);
	}
}
