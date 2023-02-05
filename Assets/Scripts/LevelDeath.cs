using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
	public GameObject youFell;
	public GameObject fadeOut;
	

	void OnTriggerEnter()
	{
		StartCoroutine(YouFellOff());
	}

	IEnumerator YouFellOff()
	{
		youFell.SetActive(true);
		
		yield return new WaitForSeconds(2);
		fadeOut.SetActive(true);
		yield return new WaitForSeconds(1);
		GlobalScore.currentScore = 0;
		SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
	}
}