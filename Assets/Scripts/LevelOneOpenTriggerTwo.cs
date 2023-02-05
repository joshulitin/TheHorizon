using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneOpenTriggerTwo : MonoBehaviour
{
	public GameObject TrapDoor;
	public GameObject BlockTwo;
	public GameObject DTrigger;

	private void OnTriggerEnter(Collider other)
	{
		TrapDoor.GetComponent<Animation>().Play("plattrigger1.2");
		BlockTwo.GetComponent<Animation>().Play("block2");
		Destroy(DTrigger);
	}
}
