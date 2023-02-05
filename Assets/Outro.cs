using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Outro : MonoBehaviour
{
	public GameObject OutroOne;
	public GameObject OutroTwo;
	public GameObject OutroThree;
	public GameObject ArtOne;
	void Start()
	{
		StartCoroutine(RunOutro());
	}
	IEnumerator RunOutro()
	{
		yield return new WaitForSeconds(1.5f);
		OutroOne.SetActive(true);
		yield return new WaitForSeconds(3.5f);
		OutroOne.SetActive(false);
		OutroTwo.SetActive(true);
		yield return new WaitForSeconds(5.5f);
		OutroTwo.SetActive(false);
		OutroThree.SetActive(true);
		yield return new WaitForSeconds(7f);
		SceneManager.LoadScene(1);
	}
}
