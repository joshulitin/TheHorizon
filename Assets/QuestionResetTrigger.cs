using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionResetTrigger : MonoBehaviour
{
	public GameObject platform;
	public GameObject platformTrigger;

	private void OnTriggerEnter(Collider other)
	{
		platform.SetActive(true);
		platformTrigger.SetActive(true);
	}
}
