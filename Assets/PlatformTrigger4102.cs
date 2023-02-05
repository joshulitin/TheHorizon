using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger4102 : MonoBehaviour
{
	public GameObject Platform2;
	public GameObject Block4102;
	public GameObject PlatformTrigger2;

	private void OnTriggerEnter(Collider other)
	{
		Platform2.GetComponent<Animation>().Play("PlatformTrigger4102");
		Block4102.GetComponent<Animation>().Play("Block4102");
		Destroy(PlatformTrigger2);
	}
}
