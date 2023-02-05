using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer2button : MonoBehaviour
{
	public GameObject button2;

	List<string> secondChoice = new List<string>() { "74", "18", "4", "3", "25" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl.randomQuestion > -1)
		{
			button2.GetComponent<Text>().text = secondChoice[textControl.randomQuestion];
		}
    }

	public void TaskOnClick()
	{	
		textControl.selectedAnswer = gameObject.name;
		textControl.choiceSelected = "y";
	}
}
