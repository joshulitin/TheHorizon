using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay1;
	public GameObject timeDisplay2;
    public bool isTakingTime = false;
    public int theSeconds = 122;
	public static int extendScore;
	public bool timerOver;

    void Update()
    {
		extendScore = theSeconds;
        if(isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;

        timeDisplay1.GetComponent<Text>().text = "" + theSeconds;
		timeDisplay2.GetComponent<Text>().text = "" + theSeconds;
		if(theSeconds <= 0)
		{
			timerOver = true;
			isTakingTime = true;
		}
		yield return new WaitForSeconds(1);
		isTakingTime = false;
	}
}
