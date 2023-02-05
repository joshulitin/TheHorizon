using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger351 : MonoBehaviour
{
	public GameObject QuizGame351;

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		QuizGame351.SetActive(true);
	}
}
