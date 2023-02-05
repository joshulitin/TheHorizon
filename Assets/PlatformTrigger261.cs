using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger261 : MonoBehaviour
{
	public GameObject Platform;
	public GameObject BlockOne;
	public GameObject DestroyTrigger;

	private void OnTriggerEnter(Collider other)
	{
		Platform.GetComponent<Animation>().Play("PlatformTrigger261");
		BlockOne.GetComponent<Animation>().Play("BlockOne261");
		Destroy(DestroyTrigger);
	}
}
