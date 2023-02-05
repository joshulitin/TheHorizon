using System.Collections;
using UnityEngine;

public class Level016 : MonoBehaviour
{
	public GameObject fadeIn;

    void Start()
    {
		RedirectToLevel.redirectToLevel = 17;
		RedirectToLevel.nextLevel = 18;
		StartCoroutine(FadeInOff());
    }

	IEnumerator FadeInOff()
	{
		yield return new WaitForSeconds(1);
		fadeIn.SetActive(false);
	}
}