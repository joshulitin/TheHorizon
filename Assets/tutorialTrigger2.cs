using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialTrigger2 : MonoBehaviour
{
	public GameObject cameraTutorial;
	public GameObject sudokuTrigger;
	public GameObject menuButton;

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		menuButton.SetActive(false);
		cameraTutorial.SetActive(true);
		sudokuTrigger.SetActive(false);
	}
}
