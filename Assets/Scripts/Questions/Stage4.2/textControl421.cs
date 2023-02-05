using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl421 : MonoBehaviour {

	
	List<string> questions = new List<string>() {"What category in the food web where an animal just eats plants", "At what habitat or place where monkeys are lived?", "Which of the following is identified as a vegetable?",
												 "Every morning, the sun rises in the ___", "Which of these foods is healthy to your body?"};

	List<string> correctAnswer = new List<string>() { "3", "2", "2", "4", "1" };

	public static string selectedAnswer;
	public static string choiceSelected = "n";
	public static int randomQuestion = -1;

	public GameObject TrapDoor;
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
				TrapDoor.GetComponent<Animation>().Play("plattrigger421");
				BlockOne.GetComponent<Animation>().Play("block421");
				Destroy(DTrigger);
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				
			}
			else
			{
				DTrigger.SetActive(false);
				TrapDoor.SetActive(false);
				BlockTwo.GetComponent<Animation>().Play("Block422");
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				randomQuestion = -1;
			}
		}
	}
}
