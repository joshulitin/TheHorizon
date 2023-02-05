using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneSixTriggerTwo : MonoBehaviour
{
	public GameObject TrapDoor;
	public GameObject BlockTwo;
	public GameObject DTrigger;

	private void OnTriggerEnter(Collider other)
	{
		TrapDoor.GetComponent<Animation>().Play("plattrigger1.6.2");
		BlockTwo.GetComponent<Animation>().Play("block162");
		Destroy(DTrigger);
	}
}
