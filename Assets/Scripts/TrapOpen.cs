using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOpen : MonoBehaviour
{
	public GameObject TrapDoor;
	public bool alreadyTriggered;

	void OnTriggerEnter()
	{
		if (!alreadyTriggered)
		{
			TrapDoor.GetComponent<Animation>().Play("TrapAnim");
			alreadyTriggered = true;
		}
	}
}
