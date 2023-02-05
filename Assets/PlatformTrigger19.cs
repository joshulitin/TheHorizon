using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger19 : MonoBehaviour
{
	public GameObject QuizGame19;

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		QuizGame19.SetActive(true);
	}
}
