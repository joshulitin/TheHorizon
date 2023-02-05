using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedIntroTrigger : MonoBehaviour
{
	public GameObject lockedIntro;
	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		lockedIntro.SetActive(true);
	}
}
