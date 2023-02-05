using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger4104 : MonoBehaviour
{
	public GameObject QuizGame4102;
	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		QuizGame4102.SetActive(true);
	}
}
