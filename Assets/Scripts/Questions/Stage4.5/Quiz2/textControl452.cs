using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl452 : MonoBehaviour {

	
	List<string> questions = new List<string>() {"What is the name of the galaxy where Earth is?", "Leaves start to change color during which season?", "It means to use less of something",
												 "The students toss their papers in the ____ bin instead of the trash can", "To make food, a plant uses air, water and _____"};

	List<string> correctAnswer = new List<string>() { "4", "3", "2", "1", "1" };

	public static string selectedAnswer;
	public static string choiceSelected = "n";
	public static int randomQuestion = -1;

	public GameObject Platform;
	public GameObject BlockThree;
	public GameObject DTrigger;
	public GameObject QuizGame19;
	public GameObject TrapdoorHinge;

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
				Platform.GetComponent<Animation>().Play("PlatformTrigger353");
				BlockThree.GetComponent<Animation>().Play("Block353");
				Destroy(DTrigger);
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
			}
			else
			{
				DTrigger.SetActive(false);
				Platform.SetActive(false);
				TrapdoorHinge.GetComponent<Animation>().Play("TrapdoorHinge352");
				QuizGame19.SetActive(false);
				Time.timeScale = 1;
				randomQuestion = -1;
			}
		}
	}
}
