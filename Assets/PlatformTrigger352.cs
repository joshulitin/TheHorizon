using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger352 : MonoBehaviour
{
	public GameObject Block351;
	public GameObject Platform3512;
	public GameObject Plattrigger3512;
	public GameObject Block352;
	public GameObject DTrigger;
	private void OnTriggerEnter(Collider other)
	{
		
		Block351.GetComponent<Animation>().Play("Block3512");
		Platform3512.GetComponent<Animation>().Play("PlatformTrigger3512");
		Plattrigger3512.SetActive(true);
		Block352.SetActive(false);
		DTrigger.SetActive(false);
	}
}
