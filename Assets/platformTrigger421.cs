using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTrigger421 : MonoBehaviour
{
	public GameObject QuizGame421;

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		QuizGame421.SetActive(true);
	}
}
