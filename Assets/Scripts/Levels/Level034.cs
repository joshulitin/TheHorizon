using System.Collections;
using UnityEngine;

public class Level034 : MonoBehaviour
{
	public GameObject fadeIn;

    void Start()
    {
		RedirectToLevel.redirectToLevel = 35;
		RedirectToLevel.nextLevel = 36;
		StartCoroutine(FadeInOff());
    }

	IEnumerator FadeInOff()
	{
		yield return new WaitForSeconds(1);
		fadeIn.SetActive(false);
	}
}