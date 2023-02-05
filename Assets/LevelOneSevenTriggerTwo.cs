using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneSevenTriggerTwo : MonoBehaviour
{
	public GameObject TrapDoor;
	public GameObject BlockTwo;
	public GameObject DTrigger;

	private void OnTriggerEnter(Collider other)
	{
		TrapDoor.GetComponent<Animation>().Play("plattrigger172");
		BlockTwo.GetComponent<Animation>().Play("block172");
		Destroy(DTrigger);
	}
}
