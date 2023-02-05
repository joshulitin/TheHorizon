using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {
	private static LevelManager instance;
	public static LevelManager Instance { get { return instance; } }

	public Text endTimerText;
	public Text endCurrencyText;
	public Text timerText;
	
	public GameObject pauseButton;
	public GameObject currentStage;
	public GameObject healthBar;
	public GameObject currentTime;
	public GameObject endGame;
	public GameObject deathObject;

	// Tutorial GameObjects
	public GameObject pauseMenu;
	public GameObject tutoPanel;
	public GameObject tutoPanel2;
	public GameObject tutoTrigger;

	//Introduction Sequence
	public GameObject introduction1;
	public GameObject introduction2;
	public GameObject nextButton1;
	public GameObject nextButton2;
	public GameObject cameraTutoPanel;
	public GameObject cameraTrigger;

	// Timer Sequence
	public GameObject timerIntro1;
	public GameObject timerIntro2;
	public GameObject nextButton3;
	public GameObject nextButton4;
	public GameObject timerTutoPanel;
	public GameObject timerTrigger;
	public bool gamePaused = false;

	//Locked Room Introduction
	public GameObject lockedIntro;
	public GameObject lockedIntro2;
	public GameObject lockedIntroTrigger;
	// Enemies Introduction
	public GameObject enemiesIntro;
	public GameObject enemiesIntro2;
	public GameObject enemiesTrigger;
	//Timer Goals
	private float levelDuration;
	private float startTime;
	public float silverTime;
	public float goldTime;

	public GameObject fadeOutFinal;
	private void Start()
	{
		endGame.SetActive(false);
		instance = this;
		startTime = Time.time;
	}
	public void Update()
	{
		levelDuration = Time.time - startTime;
		string minutes = ((int) levelDuration/ 60).ToString("00");
		string seconds = (levelDuration % 60).ToString("00.00");
		timerText.text = minutes + ":" + seconds;
	}
	public void TogglePauseMenu() {
		if (gamePaused == false)
		{
			pauseMenu.SetActive(true);
			currentStage.SetActive(true);
			gamePaused = true;
			Time.timeScale = 0;
		}
		else
		{
			pauseMenu.SetActive(false);
			currentStage.SetActive(false);
			gamePaused = false;
			Time.timeScale = 1;
		}
	}

	public void toMenu() {
		SceneManager.LoadScene(1);
		Time.timeScale = 1;
	}

	public void toNextLevel()
	{
		SceneManager.LoadScene(2);
		Time.timeScale = 1;
	}
	public void toRestart() {
		pauseMenu.SetActive(false);
		gamePaused = false;
		Time.timeScale = 1;
		SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
	}

	public void toSkip() {
		tutoPanel.SetActive(false);
		tutoPanel2.SetActive(false);
		
		pauseButton.SetActive(true);
		currentTime.SetActive(true);
		healthBar.SetActive(true);
		Time.timeScale = 1;
	}

	public void toSkipTwo()
    {
		timerTutoPanel.SetActive(false);

		pauseButton.SetActive(true);
		currentTime.SetActive(true);
		healthBar.SetActive(true);
		Time.timeScale = 1;
	}

	public void toNext() {
		tutoPanel.SetActive(false);
		tutoPanel2.SetActive(true);
	}

	public void toNext2()
	{
		introduction1.SetActive(false);
		introduction2.SetActive(true);
		nextButton1.SetActive(false);
		nextButton2.SetActive(true);
	}

	//Locked Introduction
	public void toNextLockedIntro()
    {
		lockedIntro.SetActive(false);
		lockedIntro2.SetActive(true);

    }

	public void toSkipLockedIntro()
    {
		lockedIntro.SetActive(false);
		Time.timeScale = 1;
		lockedIntroTrigger.SetActive(false);
    }
	public void toEndLockedIntro()
    {
		lockedIntro2.SetActive(false);
		Time.timeScale = 1;
		lockedIntroTrigger.SetActive(false);
    }

	//Enemies Introduction
	public void toNextEnemiesIntro()
    {
		enemiesIntro.SetActive(false);
		enemiesIntro2.SetActive(true);
    }

	public void toSkipEnemiesIntro()
    {
		enemiesIntro.SetActive(false);
		Time.timeScale = 1;
		enemiesTrigger.SetActive(false);
    }

	public void toEndEnemiesIntro()
    {
		enemiesIntro2.SetActive(false);
		Time.timeScale = 1;
		enemiesTrigger.SetActive(false);

    }
	public void toNext3()
	{
		timerIntro1.SetActive(false);
		timerIntro2.SetActive(true);
		nextButton3.SetActive(false);
		nextButton4.SetActive(true);
	}

	public void toEnd() {
		tutoPanel2.SetActive(false);
		pauseButton.SetActive(true);
		currentTime.SetActive(true);
		healthBar.SetActive(true);
		Time.timeScale = 1;
		tutoTrigger.SetActive(false);
	}
	
	public void toEnd2()
	{
		cameraTutoPanel.SetActive(false);
		pauseButton.SetActive(true);
		currentTime.SetActive(true);
		Time.timeScale = 1;
		cameraTrigger.SetActive(false);
	}

	public void toEnd3()
	{
		timerTutoPanel.SetActive(false);
		pauseButton.SetActive(true);
		currentTime.SetActive(true);
		Time.timeScale = 1;
		timerTrigger.SetActive(false);
	}

	public void Victory() {
		deathObject.SetActive(false);
		foreach (Transform t in endGame.transform.parent)
		{
			t.gameObject.SetActive(false);
		}
		endGame.SetActive(true);

		levelDuration = Time.time - startTime;
		string minutes = ((int)levelDuration / 60).ToString("00");
		string seconds = (levelDuration % 60).ToString("00.00");
		endTimerText.text = minutes + ":" + seconds;

		if (levelDuration < goldTime)
		{
			GameManager.Instance.currency += 50;
			endTimerText.color = new Color(1.0f, 0.8f, 0.0f, 1.0f);
			endCurrencyText.text = "You Earned: 50 Currencies";
		}
		else if (levelDuration < silverTime)
		{
			GameManager.Instance.currency += 25;
			endTimerText.color = new Color(0.8f, 0.8f, 0.8f, 1.0f);
			endCurrencyText.text = "You Earned: 25 Currencies";
		}
		else
		{
			GameManager.Instance.currency += 10;
			endTimerText.color = new Color(0.8f, 0.5f, 0.2f, 1.0f);
			endCurrencyText.text = "You Earned: 10 Currencies";
		}

		GameManager.Instance.Save();

		string saveString = "";
		LevelData level = new LevelData(SceneManager.GetActiveScene().name);

		saveString += (level.BestTime > levelDuration || level.BestTime == 0.0f) ? levelDuration.ToString(): level.BestTime.ToString();
		saveString += '&';
		saveString += silverTime.ToString();
		saveString += '&';
		saveString += goldTime.ToString();
		PlayerPrefs.SetString(SceneManager.GetActiveScene().name, saveString);
	}

	public void FinalVictory()
	{
		StartCoroutine(finalFadeOut());

		levelDuration = Time.time - startTime;
		string minutes = ((int)levelDuration / 60).ToString("00");
		string seconds = (levelDuration % 60).ToString("00.00");
		endTimerText.text = minutes + ":" + seconds;

		if (levelDuration < goldTime)
		{
			GameManager.Instance.currency += 50;
			endTimerText.color = new Color(1.0f, 0.8f, 0.0f, 1.0f);
			endCurrencyText.text = "You Earned: 50 Currencies";
		}
		else if (levelDuration < silverTime)
		{
			GameManager.Instance.currency += 25;
			endTimerText.color = new Color(0.8f, 0.8f, 0.8f, 1.0f);
			endCurrencyText.text = "You Earned: 25 Currencies";
		}
		else
		{
			GameManager.Instance.currency += 10;
			endTimerText.color = new Color(0.8f, 0.5f, 0.2f, 1.0f);
			endCurrencyText.text = "You Earned: 10 Currencies";
		}

		GameManager.Instance.Save();

	}

	IEnumerator finalFadeOut()
	{
		fadeOutFinal.SetActive(true);
		yield return new WaitForSeconds(1.5f);
		SceneManager.LoadScene(28);
	}
	}