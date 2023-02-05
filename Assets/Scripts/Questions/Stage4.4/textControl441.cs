using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl441 : MonoBehaviour {

	
	List<string> questions = new List<string>() {"Which would cause liquid water to change to a solid?", "An example of a gas is _____", "What weather tool is used to measure how hot or how cold something is?",
												 "____ is the process that lays down (drops) sediment in a new location", "A very flat landform with grass and very few trees is a _____"};

	List<string> correctAnswer = new List<string>() { "3", "1", "4", "4", "2" };

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
				Platform.GetComponent<Animation>().Play("PlatformTrigger341");
				BlockOne.GetComponent<Animation>().Play("Block341");
				Destroy(DTrigger);
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				
			}
			else
			{
				DTrigger.SetActive(false);
				Platform.SetActive(false);
				BlockTwo.GetComponent<Animation>().Play("TrapdoorHinge341");
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				randomQuestion = -1;
			}
		}
	}
}
