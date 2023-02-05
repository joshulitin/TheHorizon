using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer3button4102 : MonoBehaviour
{
	public GameObject button3;

	List<string> thirdChoice = new List<string>() { "Random", "rescued", "The", "gives", "They" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextControl4102.randomQuestion > -1)
		{
			button3.GetComponent<Text>().text = thirdChoice[TextControl4102.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
        TextControl4102.selectedAnswer = gameObject.name;
        TextControl4102.choiceSelected = "y";
	}
}
