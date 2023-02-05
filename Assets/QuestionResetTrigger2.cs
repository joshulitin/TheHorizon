using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionResetTrigger2 : MonoBehaviour
{
	public GameObject platform2;
	public GameObject platformTrigger2;

	private void OnTriggerEnter(Collider other)
	{
		platform2.SetActive(true);
		platformTrigger2.SetActive(true);
	}
}
