using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer4button421 : MonoBehaviour
{
	public GameObject button4;

	List<string> fourthChoice = new List<string>() { "Decomposition", "desert", "pear", "east", "Pizza" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl421.randomQuestion > -1)
		{	
			button4.GetComponent<Text>().text = fourthChoice[textControl421.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl421.selectedAnswer = gameObject.name;
		textControl421.choiceSelected = "y";
	}
}
