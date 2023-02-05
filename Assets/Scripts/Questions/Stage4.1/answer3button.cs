using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer3button : MonoBehaviour
{
	public GameObject button3;

	List<string> thirdChoice = new List<string>() { "59", "11", "16", "9", "35" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl.randomQuestion > -1)
		{
			button3.GetComponent<Text>().text = thirdChoice[textControl.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl.selectedAnswer = gameObject.name;
		textControl.choiceSelected = "y";
	}
}
