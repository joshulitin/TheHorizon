using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer2button441 : MonoBehaviour
{
	public GameObject button2;

	List<string> secondChoice = new List<string>() { "dripping", "A marker", "Boiling Point", "Disposition", "plain" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl441.randomQuestion > -1)
		{
			button2.GetComponent<Text>().text = secondChoice[textControl441.randomQuestion];
		}
    }

	public void TaskOnClick()
	{	
		textControl441.selectedAnswer = gameObject.name;
		textControl441.choiceSelected = "y";
	}
}
