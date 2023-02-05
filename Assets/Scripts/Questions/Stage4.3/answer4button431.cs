using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer4button431 : MonoBehaviour
{
	public GameObject button4;

	List<string> fourthChoice = new List<string>() { "4", "dog", "10", "50", "XVII" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl431.randomQuestion > -1)
		{	
			button4.GetComponent<Text>().text = fourthChoice[textControl431.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl431.selectedAnswer = gameObject.name;
		textControl431.choiceSelected = "y";
	}
}
