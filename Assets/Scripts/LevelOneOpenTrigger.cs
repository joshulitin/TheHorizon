using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneOpenTrigger : MonoBehaviour
{
	public GameObject TrapDoor;
	public GameObject BlockOne;
	
	public GameObject DTrigger;

	private void OnTriggerEnter(Collider other)
	{
		TrapDoor.GetComponent<Animation>().Play("plattrigger1.1");
		BlockOne.GetComponent<Animation>().Play("block1");
		Destroy(DTrigger);
	}
}
