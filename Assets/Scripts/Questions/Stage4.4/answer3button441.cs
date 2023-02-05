using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer3button441 : MonoBehaviour
{
	public GameObject button3;

	List<string> thirdChoice = new List<string>() { "freezing", "A rock", "Air Pressure", "Meandering", "hill" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl441.randomQuestion > -1)
		{
			button3.GetComponent<Text>().text = thirdChoice[textControl441.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl441.selectedAnswer = gameObject.name;
		textControl441.choiceSelected = "y";
	}
}
