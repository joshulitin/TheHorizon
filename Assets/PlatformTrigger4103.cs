using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger4103 : MonoBehaviour
{
	public GameObject QuizGame4101;

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		QuizGame4101.SetActive(true);
	}
}
