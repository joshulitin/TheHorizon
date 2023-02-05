using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer3button410 : MonoBehaviour
{
	public GameObject button3;

	List<string> thirdChoice = new List<string>() { "this", "told", "Pleasant short", "Imperative", "He" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextControl4101.randomQuestion > -1)
		{
			button3.GetComponent<Text>().text = thirdChoice[TextControl4101.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
        TextControl4101.selectedAnswer = gameObject.name;
        TextControl4101.choiceSelected = "y";
	}
}
