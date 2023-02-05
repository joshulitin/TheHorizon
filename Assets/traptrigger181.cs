using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traptrigger181 : MonoBehaviour
{
	public GameObject TrapDoor;
	public GameObject DestroyTrigger;

	private void OnTriggerEnter(Collider other)
	{
		TrapDoor.GetComponent<Animation>().Play("traptrigger1");
		Destroy(DestroyTrigger);
	}
}
