using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneSevenTrigger : MonoBehaviour
{
	public GameObject TrapDoor;
	public GameObject BlockOne;
	public GameObject DTrigger;

	private void OnTriggerEnter(Collider other)
	{
		TrapDoor.GetComponent<Animation>().Play("plattrigger1.7");
		BlockOne.GetComponent<Animation>().Play("block171");
		Destroy(DTrigger);
	}
}
