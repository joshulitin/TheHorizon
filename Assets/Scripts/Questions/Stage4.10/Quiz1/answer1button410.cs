using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer1button410 : MonoBehaviour
{
	public GameObject button1;

	List<string> firstChoice = new List<string>() { "are", "mixes", "Goes mother's friend", "Declarative", "It" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextControl4101.randomQuestion > -1)
		{
			button1.GetComponent<Text>().text = firstChoice[TextControl4101.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		TextControl4101.selectedAnswer = gameObject.name;
		TextControl4101.choiceSelected = "y";
		//Debug.Log(gameObject.name);
	}
}
