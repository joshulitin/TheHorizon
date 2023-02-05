using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer4button4102 : MonoBehaviour
{
	public GameObject button4;

	List<string> fourthChoice = new List<string>() { "Complex", "cat", "Is", "bench", "Doesn't" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextControl4102.randomQuestion > -1)
		{	
			button4.GetComponent<Text>().text = fourthChoice[TextControl4102.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
        TextControl4102.selectedAnswer = gameObject.name;
        TextControl4102.choiceSelected = "y";
	}
}
