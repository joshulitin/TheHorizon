using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer1button421 : MonoBehaviour
{
	public GameObject button1;

	List<string> firstChoice = new List<string>() { "Omnivore", "ocean", "banana", "north", "Carrot" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl421.randomQuestion > -1)
		{
			button1.GetComponent<Text>().text = firstChoice[textControl421.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl421.selectedAnswer = gameObject.name;
		textControl421.choiceSelected = "y";
		//Debug.Log(gameObject.name);
	}
}
