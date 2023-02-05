using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalStageIntroduction : MonoBehaviour
{
	public GameObject fsIntro;
	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		fsIntro.SetActive(true);
	}
}
