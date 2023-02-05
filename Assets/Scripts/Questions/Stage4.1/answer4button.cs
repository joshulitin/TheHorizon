using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer4button : MonoBehaviour
{
	public GameObject button4;

	List<string> fourthChoice = new List<string>() { "64", "5", "1", "18", "50" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl.randomQuestion > -1)
		{	
			button4.GetComponent<Text>().text = fourthChoice[textControl.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl.selectedAnswer = gameObject.name;
		textControl.choiceSelected = "y";
	}
}
