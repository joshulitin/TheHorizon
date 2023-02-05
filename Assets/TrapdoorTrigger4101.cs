using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorTrigger4101 : MonoBehaviour
{
	public GameObject Trapdoor;
	public GameObject TrapdoorTrigger;

	private void OnTriggerEnter(Collider other)
	{
		Trapdoor.GetComponent<Animation>().Play("TrapdoorTrigger4101");
		
		Destroy(TrapdoorTrigger);
	}
}
