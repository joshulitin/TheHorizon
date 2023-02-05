using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl451 : MonoBehaviour {

	
	List<string> questions = new List<string>() {"What basic part of the plant that always blooms in the morning?", "At what habitat or place where monkeys are lived?", "Our ears can sense _____",
												 "Bread was made from ____", "Identify which object will melt in the sun."};

	List<string> correctAnswer = new List<string>() { "1", "3", "4", "2", "2" };

	public static string selectedAnswer;
	public static string choiceSelected = "n";
	public static int randomQuestion = -1;

	public GameObject Platform;
	public GameObject BlockTwo;
	public GameObject TrapdoorHinge;
	public GameObject BlockOne;
	public GameObject DTrigger;
	public GameObject QuizGame19;
	

	private void Start() {
		randomQuestion = -1;
	}

	void Update() {
		if (randomQuestion == -1)
		{
			randomQuestion = Random.Range(0, 5);
		}
		if (randomQuestion > -1)
		{
			GetComponent<Text>().text = questions[randomQuestion];
		}
		//Debug.Log(questions[randomQuestion]);

		if(choiceSelected == "y")
		{
			choiceSelected = "n";
			if (correctAnswer[randomQuestion] == selectedAnswer)
			{
				Platform.GetComponent<Animation>().Play("PlatformTrigger351");
				BlockOne.GetComponent<Animation>().Play("Block351");
				BlockTwo.GetComponent<Animation>().Play("Block352");
				DTrigger.SetActive(false);
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				randomQuestion = -1;
			}
			else
			{
				DTrigger.SetActive(false);
				Platform.SetActive(false);
				TrapdoorHinge.GetComponent<Animation>().Play("TrapdoorHinge351");
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				randomQuestion = -1;
			}
		}
	}
}
