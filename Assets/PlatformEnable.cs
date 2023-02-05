using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformEnable : MonoBehaviour
{
	public GameObject platform;
	public GameObject platformTrigger;

	private void OnTriggerEnter(Collider other)
	{
		platform.SetActive(true);
		platformTrigger.SetActive(true);
	}
}
