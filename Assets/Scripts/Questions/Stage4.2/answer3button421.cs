using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer3button421 : MonoBehaviour
{
	public GameObject button3;

	List<string> thirdChoice = new List<string>() { "Herbivore", "iceberg", "apple", "west", "French fries" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl421.randomQuestion > -1)
		{
			button3.GetComponent<Text>().text = thirdChoice[textControl421.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl421.selectedAnswer = gameObject.name;
		textControl421.choiceSelected = "y";
	}
}
