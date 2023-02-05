using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer1button431 : MonoBehaviour
{
	public GameObject button1;

	List<string> firstChoice = new List<string>() { "8", "human", "14", "40", "XII" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl431.randomQuestion > -1)
		{
			button1.GetComponent<Text>().text = firstChoice[textControl431.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl431.selectedAnswer = gameObject.name;
		textControl431.choiceSelected = "y";
		//Debug.Log(gameObject.name);
	}
}
