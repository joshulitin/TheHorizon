using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer4button451 : MonoBehaviour
{
	public GameObject button4;

	List<string> fourthChoice = new List<string>() { "leaf", "ocean", "hearing", "potato", "ball" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl451.randomQuestion > -1)
		{	
			button4.GetComponent<Text>().text = fourthChoice[textControl451.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl451.selectedAnswer = gameObject.name;
		textControl451.choiceSelected = "y";
	}
}
