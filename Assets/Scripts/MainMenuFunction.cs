using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
	public AudioSource buttonPress;
	public GameObject leaderBoard;
	public int bestScore;
	public GameObject bestScoreDisplay;

	private void Start()
	{
		bestScore = PlayerPrefs.GetInt("LevelScore");
		bestScoreDisplay.GetComponent<Text>().text = "Highscore: " + bestScore;
	}

	public void PlayGame()
	{
		buttonPress.Play();
		RedirectToLevel.redirectToLevel = 3;
		SceneManager.LoadScene(2);
	}

	public void StageSelect()
	{
		SceneManager.LoadScene(5);
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void ResetScore()
	{
		buttonPress.Play();
		PlayerPrefs.SetInt("LevelScore", 0);
	}
}