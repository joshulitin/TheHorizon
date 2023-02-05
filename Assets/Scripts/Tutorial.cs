using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
	public GameObject pauseButton;
	public GameObject currentTime;
	public GameObject healthBar;

    // Start is called before the first frame update
    void Awake()
    {
		StartCoroutine(Tutorials());
		pauseButton.SetActive(false);
		currentTime.SetActive(false);
		healthBar.SetActive(false);
	}

	IEnumerator Tutorials()
	{
		yield return new WaitForSeconds(0);
		Time.timeScale = 0;


	}
}

