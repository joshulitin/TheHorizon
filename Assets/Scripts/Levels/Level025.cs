using System.Collections;
using UnityEngine;

public class Level025 : MonoBehaviour
{
	public GameObject fadeIn;

    void Start()
    {
		RedirectToLevel.redirectToLevel = 26;
		RedirectToLevel.nextLevel = 27;
		StartCoroutine(FadeInOff());
    }

	IEnumerator FadeInOff()
	{
		yield return new WaitForSeconds(1);
		fadeIn.SetActive(false);
	}
}