using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer2button431 : MonoBehaviour
{
	public GameObject button2;

	List<string> secondChoice = new List<string>() { "9", "rat", "13", "45", "XI" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl431.randomQuestion > -1)
		{
			button2.GetComponent<Text>().text = secondChoice[textControl431.randomQuestion];
		}
    }

	public void TaskOnClick()
	{	
		textControl431.selectedAnswer = gameObject.name;
		textControl431.choiceSelected = "y";
	}
}
