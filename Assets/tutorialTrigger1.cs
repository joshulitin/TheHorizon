using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialTrigger1 : MonoBehaviour
{
	public GameObject tutorialPanel1;
	public GameObject sudokuTrigger;
	public GameObject pauseButton;

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		tutorialPanel1.SetActive(true);
		sudokuTrigger.SetActive(false);
		pauseButton.SetActive(false);
	}
}
