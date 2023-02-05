using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer1button441 : MonoBehaviour
{
	public GameObject button1;

	List<string> firstChoice = new List<string>() { "heating", "Hydrogen", "Temperature", "Weathering", "valley" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl441.randomQuestion > -1)
		{
			button1.GetComponent<Text>().text = firstChoice[textControl441.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl441.selectedAnswer = gameObject.name;
		textControl441.choiceSelected = "y";
		//Debug.Log(gameObject.name);
	}
}
