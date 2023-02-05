using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer2button4102 : MonoBehaviour
{
	public GameObject button2;

	List<string> secondChoice = new List<string>() { "Fact", "tree", "An", "swing", "You" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextControl4102.randomQuestion > -1)
		{
			button2.GetComponent<Text>().text = secondChoice[TextControl4102.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
        TextControl4102.selectedAnswer = gameObject.name;
        TextControl4102.choiceSelected = "y";
	}
}
