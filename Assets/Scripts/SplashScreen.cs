using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
	public GameObject dialogueOne;
	public GameObject dialogueTwo;
	public GameObject dialogueThree;
	public GameObject dialogueFour;
	public GameObject dialogueFive;
	public GameObject dialogueSix;
	public GameObject dialogueSeven;
	public GameObject introOne;
	public GameObject introTwo;
	public GameObject introThree;
	public GameObject toSkip;
	void Start()
	{
		StartCoroutine(RunSplash());
	}

	IEnumerator RunSplash()
	{
		yield return new WaitForSeconds(1.5f);
		dialogueOne.SetActive(true);
		yield return new WaitForSeconds(3.5f);
		dialogueOne.SetActive(false);
		dialogueTwo.SetActive(true);
		toSkip.SetActive(true);
		yield return new WaitForSeconds(5.5f);
		dialogueTwo.SetActive(false);
		dialogueThree.SetActive(true);
		yield return new WaitForSeconds(7.5f);
		dialogueThree.SetActive(false);
		dialogueFour.SetActive(true);
		introOne.SetActive(false);
		introTwo.SetActive(true);
		yield return new WaitForSeconds(8.5f);
		dialogueFour.SetActive(false);
		dialogueFive.SetActive(true);
		yield return new WaitForSeconds(8.7f);
		dialogueFive.SetActive(false);
		dialogueSix.SetActive(true);
		yield return new WaitForSeconds(11f);
		SceneManager.LoadScene(1);
	}
}
