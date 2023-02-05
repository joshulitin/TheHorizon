using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl431 : MonoBehaviour {

	
	List<string> questions = new List<string>() {"Even numbers are ending 2, 4, 6, ____, and 0.", "Which of the following is not a mammal", "There 5 assistants and 4 executives. How many staff are working there?",
												 "Find the product of 9x5", "What is the Roman numeral equivalent of 15"};

	List<string> correctAnswer = new List<string>() { "1", "3", "1", "2", "3" };

	public static string selectedAnswer;
	public static string choiceSelected = "n";
	public static int randomQuestion = -1;

	public GameObject Platform;
	public GameObject BlockOne;
	public GameObject DTrigger;
	public GameObject QuizGame19;
	public GameObject BlockTwo;

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
				Platform.GetComponent<Animation>().Play("PlatformTrigger431");
				BlockOne.GetComponent<Animation>().Play("Block431");
				Destroy(DTrigger);
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				
			}
			else
			{
				DTrigger.SetActive(false);
				Platform.SetActive(false);
				BlockTwo.GetComponent<Animation>().Play("TrapdoorHinge431");
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				randomQuestion = -1;
			}
		}
	}
}
