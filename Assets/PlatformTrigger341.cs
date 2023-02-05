using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger341 : MonoBehaviour
{
	public GameObject QuizGame341;

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		QuizGame341.SetActive(true);
	}
}
