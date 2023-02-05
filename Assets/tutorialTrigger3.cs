using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialTrigger3 : MonoBehaviour
{
	public GameObject timerTutorial;
	public GameObject sudokuTrigger;
	public GameObject menuButton;

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		menuButton.SetActive(false);
		timerTutorial.SetActive(true);
		sudokuTrigger.SetActive(false);
	}
}
