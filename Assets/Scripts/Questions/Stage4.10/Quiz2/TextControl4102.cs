using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl4102 : MonoBehaviour
{


	List<string> questions = new List<string>() {"A bird ate a worm. This sentence is a fact, fiction, complex, or random?", "The firemen rescued the cat from the tree. Where is the verb in the sentence?", "Find the correct article in this sentence: ____ banana",
												 "Identify which is an adverb", "Which of these examples are contraction words?"};

	List<string> correctAnswer = new List<string>() { "2", "3", "1", "1", "4" };

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
				TrapDoor.GetComponent<Animation>().Play("QuizPlatform2");
				BlockOne.GetComponent<Animation>().Play("Block4104");
				Destroy(DTrigger);
				QuizGame19.SetActive(false);
				Time.timeScale = 1;

			}
			else
			{
				DTrigger.SetActive(false);
				TrapDoor.SetActive(false);
				BlockTwo.GetComponent<Animation>().Play("TrapdoorTrigger4104");
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				randomQuestion = -1;
			}
		}
	}
}
