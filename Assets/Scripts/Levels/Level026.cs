using System.Collections;
using UnityEngine;

public class Level026: MonoBehaviour
{
	public GameObject fadeIn;

    void Start()
    {
		RedirectToLevel.redirectToLevel = 27;
		RedirectToLevel.nextLevel = 28;
		StartCoroutine(FadeInOff());
    }

	IEnumerator FadeInOff()
	{
		yield return new WaitForSeconds(1);
		fadeIn.SetActive(false);
	}
}