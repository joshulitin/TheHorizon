using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl : MonoBehaviour {

	
	List<string> questions = new List<string>() {"What is 25 plus 39", "What is 15 minus 3", "What is 16 divided by 4",
												 "What is the 3 times 6", "What is 5 times 7"};

	List<string> correctAnswer = new List<string>() { "4", "1", "2", "4", "3" };

	List<int> previousQuestions = new List<int>() { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
	public int questionNumber = 0;

	public static string selectedAnswer;
	public static string choiceSelected = "n";
	public static int randomQuestion = -1;

	public GameObject TrapDoor;
	public GameObject BlockOne;
	public GameObject DTrigger;
	public GameObject QuizGame19;

	private void Start() {
		//GetComponent<Text>().text = questions[0];
	}

	void Update() {
		if (randomQuestion == -1)
		{
			randomQuestion = Random.Range(0, 5);
			for (int i = 0; i < 22; i++)
			{
				if (randomQuestion != previousQuestions[i])
				{

				}
				else
				{
					randomQuestion = 1;
				}
			}
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
				Debug.Log("Correct!" + " " + randomQuestion);
				TrapDoor.GetComponent<Animation>().Play("plattrigger191");
				BlockOne.GetComponent<Animation>().Play("block191");
				Destroy(DTrigger);
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
			}
			else
			{
				Debug.Log("Incorrect");
			}
		}
	}
}
