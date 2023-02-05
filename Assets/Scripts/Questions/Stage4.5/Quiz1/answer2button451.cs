using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer2button451 : MonoBehaviour
{
	public GameObject button2;

	List<string> secondChoice = new List<string>() { "roots", "desert", "touch", "wheat", "ice" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl451.randomQuestion > -1)
		{
			button2.GetComponent<Text>().text = secondChoice[textControl451.randomQuestion];
		}
    }

	public void TaskOnClick()
	{	
		textControl451.selectedAnswer = gameObject.name;
		textControl451.choiceSelected = "y";
	}
}
