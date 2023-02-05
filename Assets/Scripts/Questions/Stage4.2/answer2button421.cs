using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer2button421 : MonoBehaviour
{
	public GameObject button2;

	List<string> secondChoice = new List<string>() { "Carnivore", "forest", "radish", "south", "Ice cream" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl421.randomQuestion > -1)
		{
			button2.GetComponent<Text>().text = secondChoice[textControl421.randomQuestion];
		}
    }

	public void TaskOnClick()
	{	
		textControl421.selectedAnswer = gameObject.name;
		textControl421.choiceSelected = "y";
	}
}
