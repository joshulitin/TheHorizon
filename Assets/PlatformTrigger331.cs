using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger331 : MonoBehaviour
{
	public GameObject QuizGame331;

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		QuizGame331.SetActive(true);
	}
}
