using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger353 : MonoBehaviour
{
	public GameObject QuizGame352;

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		QuizGame352.SetActive(true);
	}
}
