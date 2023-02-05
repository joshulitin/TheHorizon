using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer3button431 : MonoBehaviour
{
	public GameObject button3;

	List<string> thirdChoice = new List<string>() { "1", "ant", "11", "55", "XV" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl431.randomQuestion > -1)
		{
			button3.GetComponent<Text>().text = thirdChoice[textControl431.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl431.selectedAnswer = gameObject.name;
		textControl431.choiceSelected = "y";
	}
}
