using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer1 : MonoBehaviour
{
	List<string> firstChoice = new List<string>() { "First", "Second", "Third",
													"Fourth", "Fifth"};
    // Start is called before the first frame update
    void Start()
    {
		//GetComponent<Text>().text = firstChoice[0];
    }

    // Update is called once per frame
    void Update()
    {
		if (textControl.randomQuestion >-1)
		{
			GetComponent<Text>().text = firstChoice[textControl.randomQuestion];
		}
	}

	public void TaskonClick()
	{
		textControl.selectedAnswer = gameObject.name;
		textControl.choiceSelected = "y";
	}
}
