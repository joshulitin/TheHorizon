using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl4101 : MonoBehaviour
{


	List<string> questions = new List<string>() {"Which of these examples is a noun", "The painter ____ the colors", "Which of these sentences is an adjective?",
												 "(Your teacher is nice!) What kind of sentence is this?", "John puts the books on the table. What is the personal pronoun replace the word, (John)"};

	List<string> correctAnswer = new List<string>() { "4", "1", "2", "4", "3" };

	public static string selectedAnswer;
	public static string choiceSelected = "n";
	public static int randomQuestion = -1;

	public GameObject TrapDoor;
	public GameObject BlockOne;
	public GameObject DTrigger;
	public GameObject QuizGame19;
	public GameObject BlockTwo;

	private void Start()
	{
		randomQuestion = -1;
	}

	void Update()
	{
		if (randomQuestion == -1)
		{
			randomQuestion = Random.Range(0, 5);
		}
		if (randomQuestion > -1)
		{
			GetComponent<Text>().text = questions[randomQuestion];
		}
		//Debug.Log(questions[randomQuestion]);

		if (choiceSelected == "y")
		{
			choiceSelected = "n";
			if (correctAnswer[randomQuestion] == selectedAnswer)
			{
				TrapDoor.GetComponent<Animation>().Play("QuizPlatform4101");
				BlockOne.GetComponent<Animation>().Play("Block4103");
				Destroy(DTrigger);
				QuizGame19.SetActive(false);
				Time.timeScale = 1;

			}
			else
			{
				DTrigger.SetActive(false);
				TrapDoor.SetActive(false);
				BlockTwo.GetComponent<Animation>().Play("TrapDoorTrigger4102");
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				randomQuestion = -1;
			}
		}
	}
}
