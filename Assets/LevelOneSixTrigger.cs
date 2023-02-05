using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneSixTrigger : MonoBehaviour
{
	public GameObject TrapDoor;
	public GameObject BlockOne;
	public GameObject DTrigger;

	private void OnTriggerEnter(Collider other)
	{
		TrapDoor.GetComponent<Animation>().Play("plattrigger1.6");
		BlockOne.GetComponent<Animation>().Play("block161");
		Destroy(DTrigger);
	}
}
