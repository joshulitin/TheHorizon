using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer3 : MonoBehaviour
{
	List<string> thirdChoice = new List<string>() { "First", "Second", "Third",
													"Fourth", "Fifth"};
    // Start is called before the first frame update
    void Start()
    {
		//GetComponent<Text>().text = thirdChoice[0];
    }

    // Update is called once per frame
    void Update()
    {
		if (textControl.randomQuestion > -1)
		{
			GetComponent<Text>().text = thirdChoice[textControl.randomQuestion];
		}
	}

	public void TaskonClick()
	{
		textControl.selectedAnswer = gameObject.name;
		textControl.choiceSelected = "y";
	}
}
