using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesIntroTrigger : MonoBehaviour
{
	public GameObject enemiesIntro;
	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		enemiesIntro.SetActive(true);
	}
}
