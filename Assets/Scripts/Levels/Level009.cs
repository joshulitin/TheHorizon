using System.Collections;
using UnityEngine;

public class Level009 : MonoBehaviour
{
	public GameObject fadeIn;

    void Start()
    {
		RedirectToLevel.redirectToLevel = 10;
		RedirectToLevel.nextLevel = 11;
		StartCoroutine(FadeInOff());
    }

	IEnumerator FadeInOff()
	{
		yield return new WaitForSeconds(1);
		fadeIn.SetActive(false);
	}
}