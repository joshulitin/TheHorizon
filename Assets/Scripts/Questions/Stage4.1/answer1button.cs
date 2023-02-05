using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer1button : MonoBehaviour
{
	public GameObject button1;

	List<string> firstChoice = new List<string>() { "54", "12", "3", "5", "1" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl.randomQuestion > -1)
		{
			button1.GetComponent<Text>().text = firstChoice[textControl.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl.selectedAnswer = gameObject.name;
		textControl.choiceSelected = "y";
		//Debug.Log(gameObject.name);
	}
}
