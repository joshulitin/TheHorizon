using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour {
    public GameObject levelTimer;
	public GameObject timeLeft;
	public GameObject theScore;
	public GameObject totalScore;
	public GameObject deathBox;
	public GameObject fadeOut;

	public int timeCalc;
	public int scoreCalc;
	public int totalScoreCount;	

    void OnTriggerEnter() {
		GetComponent<BoxCollider>().enabled = false;
		
		timeCalc = GlobalTimer.extendScore * 100;
		timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " x 100";
		theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
		totalScoreCount = GlobalScore.currentScore + timeCalc;
		totalScore.GetComponent<Text>().text = "Total Score: " + totalScoreCount;
		PlayerPrefs.SetInt("LevelScore", totalScoreCount);
		levelTimer.SetActive(false);
		StartCoroutine(CalculateScore());
    }

	IEnumerator CalculateScore() {
		deathBox.SetActive(false);
		timeLeft.SetActive(true);
		yield return new WaitForSeconds(0.50f);
		theScore.SetActive(true);
		yield return new WaitForSeconds(0.50f);
		totalScore.SetActive(true);
		yield return new WaitForSeconds(2f);
		fadeOut.SetActive(true);
		yield return new WaitForSeconds(2f);
		GlobalScore.currentScore = 0;
		SceneManager.LoadScene(RedirectToLevel.nextLevel);
	}
}