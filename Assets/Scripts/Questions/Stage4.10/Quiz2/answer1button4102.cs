using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer1button4102 : MonoBehaviour
{
	public GameObject button1;

	List<string> firstChoice = new List<string>() { "Fiction", "firemen", "A", "lovely", "I was" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextControl4102.randomQuestion > -1)
		{
			button1.GetComponent<Text>().text = firstChoice[TextControl4102.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		TextControl4102.selectedAnswer = gameObject.name;
		TextControl4102.choiceSelected = "y";
		//Debug.Log(gameObject.name);
	}
}
