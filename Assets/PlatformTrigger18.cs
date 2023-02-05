using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger18 : MonoBehaviour
{
	public GameObject TrapDoor;
	public GameObject BlockOne;
	public GameObject DTrigger;
	public GameObject BlockTwo;

	private void OnTriggerEnter(Collider other)
	{
		TrapDoor.GetComponent<Animation>().Play("plattrigger181");
		BlockOne.GetComponent<Animation>().Play("block181");
		BlockTwo.GetComponent<Animation>().Play("Block312");
		Destroy(DTrigger);
	}
}