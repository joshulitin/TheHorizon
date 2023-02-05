using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer1button451 : MonoBehaviour
{
	public GameObject button1;

	List<string> firstChoice = new List<string>() { "flower", "iceberg", "smell", "rice", "watch" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl451.randomQuestion > -1)
		{
			button1.GetComponent<Text>().text = firstChoice[textControl451.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl451.selectedAnswer = gameObject.name;
		textControl451.choiceSelected = "y";
		//Debug.Log(gameObject.name);
	}
}
